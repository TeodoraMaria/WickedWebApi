using System.Linq;
using System.Text.RegularExpressions;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EPPlus.DataExtractor;
using EPPlus.DataExtractor.Data;
using OfficeOpenXml;
using OfficeOpenXml.FormulaParsing.Utilities;
using OfficeOpenXml.Table;
using WickedWebApi.BL.Models;
using WickedWebApi.BL.Models.Misc;
using WickedWebApi.TL.Common;
using WickedWebApi.TL.Commun;

namespace WickedWebApi.BL
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.IO;


    /// <summary>
    /// The excel reader.
    /// </summary>
    public class ExcelReader
    {
      
        public static TimeTable ReadTimeTable(string filePath)
        {
            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet excelWorksheet = package.Workbook.Worksheets.First();
                if(excelWorksheet==null) return null;

                #region Groups
                List<GroupDto> tempGroupDtos = excelWorksheet.Extract<GroupDto>().WithProperty(p => p.Name, "C").GetData(8, 300).Where(p => p.Name != null).ToList();
                int id = 1;
                tempGroupDtos.ForEach(groupDto => groupDto.Id = id++);
                List<GroupDto> groupDtos = new List<GroupDto>();

                tempGroupDtos.ForEach(group =>
                {
                    group.SemiGroup = "A";
                    groupDtos.Add(group);
                    GroupDto groupB = new GroupDto(group.Id,group.Name,"B");
                    groupDtos.Add(groupB);
                });



                #endregion

                excelWorksheet.Cells[8,5,300,50].ToList().ForEach(cell =>
                {
                    //if (cell.GetValue<string>() != null) return;
                    if (!cell.Merge && string.IsNullOrEmpty(cell.Text)) return;

         
                    string value = GoUp(excelWorksheet,cell.Start.Row, cell.Start.Column);
                    cell.Value = value;
                    if (value.Split(",".ToCharArray()).Length > 2)
                    {
                        if (value.Substring(value.Length - 7).Equals(",Impara"))
                            value = value.Substring(0, value.Length - 7);
                        else if (value.Substring(value.Length - 5).Equals(",Para"))
                            value = value.Substring(0, value.Length - 5);
                    }
                    if (cell.Start.Row % 2 == 0)
                    {
                        cell.Value = value + "," + "Impara";
                    }
                    else
                    {
                        cell.Value = value + "," + "Para";

                    }

                });


                excelWorksheet.Cells[6,5,6,50].ToList().ForEach(cell =>
                {
                    //if (!string.IsNullOrEmpty(cell.Text)) return;
                    if (!cell.Merge) return;


                    string value = GoLeft(excelWorksheet, cell.Start.Row, cell.Start.Column);
                    cell.Value = value;

                    excelWorksheet.Cells[cell.Start.Row + 1, cell.Start.Column].Value =cell.Text +"|"+excelWorksheet.Cells[cell.Start.Row + 1, cell.Start.Column].Text;

                });

                List<RowAppointments> rowAppointmentses = excelWorksheet.Extract<RowAppointments>().WithProperty(p => p.Group, "C",
                        setPropertyValueCallback: (context, value) =>
                        {
                            if (value != null) return;
                            if (!excelWorksheet.Cells[context.CellAddress.Row, 3].Merge) return;


                            value = GoUp(excelWorksheet, context.CellAddress.Row,3);
                            excelWorksheet.Cells[context.CellAddress.Row, 3].Value = value;
                        }
                    ).WithProperty(p=>p.SemiGroup ,"D",
                        setPropertyValueCallback: (context, value) =>
                        {
                            if (value != null) return;
                            if (!excelWorksheet.Cells[context.CellAddress.Row,4].Merge) return;

                            value = GoUp(excelWorksheet, context.CellAddress.Row,4);
                            excelWorksheet.Cells[context.CellAddress.Row, 4].Value = value;
                        }
                    )
                    .WithCollectionProperty(p => p.AppointmentExcelReads, item => item.AppointmentDate, 7,
                        item => item.AppointmentString, "E", "AK").GetData(8,300).ToList();

                TimeTable timeTable = new TimeTable();

                timeTable.Groups = groupDtos;
                

                rowAppointmentses.ForEach(rowAppointment =>
                {
                    GroupDto groupDto = groupDtos.Find(group =>
                        group.Name.Equals(rowAppointment.Group) && group.SemiGroup.Equals(rowAppointment.SemiGroup));
                    
                    rowAppointment.AppointmentExcelReads.Where(ap=> ap.AppointmentString!=null).ToList().ForEach(appointment =>
                    {
                        string[] date = appointment.AppointmentDate.Split("|".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);

                        string[] split = appointment.AppointmentString.Split(",".ToCharArray(),StringSplitOptions.RemoveEmptyEntries);
                        if(split.Length!=5)
                            return;
                        SubjectDto subjectDto = timeTable.Subjects.FirstOrDefault(subj => subj.Name.Equals(split[0]));
                        ClassDto classDto =null;
                        if (subjectDto == null)
                        {
                            subjectDto = new SubjectDto(timeTable.Subjects.Count,split[0]);  
                            timeTable.Subjects.Add(subjectDto);
                        }
                        else { 
                            classDto = timeTable.Classes.FirstOrDefault(classTemp => classTemp.Subject.Name.Equals(split[0]) && classTemp.ClassType.ToString().Equals(split[1]));
                        }

                        if (classDto==null)
                        {
                            classDto = new ClassDto(timeTable.Classes.Count,subjectDto,ClassTypeEnumExtension.StringToEnum(split[1]) );
                            timeTable.Classes.Add(classDto);
                        }

                        string ClassRoom = split[2];

                        date[0] = date[0] +" "+ split[4];

                        TeacherDto teacherDto = timeTable.Teachers.FirstOrDefault(teacher=> teacher.Name.Equals(split[3]));
                        if (teacherDto == null)
                        {
                            teacherDto = new TeacherDto(timeTable.Teachers.Count,split[3]);
                            timeTable.Teachers.Add(teacherDto);
                        }
                        AppointmentDto appointmentDTO = new AppointmentDto(timeTable.Appointments.Count,classDto ,teacherDto,date[0],date[1] , new Building(),ClassRoom,groupDto );
                        timeTable.Appointments.Add(appointmentDTO);
                    });
                });


            }

            return null;

        }

        public static GroupTable ReadGroupDto(string filePath)
        {

            FileInfo fileInfo = new FileInfo(filePath);

            using (ExcelPackage package = new ExcelPackage(fileInfo))
            {
                ExcelWorksheet excelWorksheet = package.Workbook.Worksheets.First();
                if (excelWorksheet == null) return null;

                List<AccountDto> accountDtos = excelWorksheet.Extract<AccountDto>().WithProperty(p => p.Email, "C")
                    .GetData(8, i => !string.IsNullOrEmpty(excelWorksheet.Cells[i, 3].Text)).ToList();
                string groupName = excelWorksheet.Cells[5,1].Text;
                groupName = groupName.Split(":".ToCharArray()).First(g=> g.Contains("anul")).Split(",".ToCharArray()).First().Replace(" ","");
                GroupTable groupTable = new GroupTable(groupName);
                accountDtos.ForEach(account=> groupTable.AddStudent(new StudentDto(account)));
                //groupTable.GroupDto = new GroupDto(-1,);

            }

            return null;
        }

      

        private static string GoUp(ExcelWorksheet excelWorksheet, int startingRow,int column)
        {
            string s;
            while (true)
            {
                if (startingRow <= 0)
                    return "";

                s = excelWorksheet.Cells[startingRow--, column].GetValue<string>();
                if (s != null)
                    break;
            }
            return s;

        }
        private static string GoLeft(ExcelWorksheet excelWorksheet, int row, int startingColumn)
        {
            string s;
            while (true)
            {
                if (startingColumn <= 0)
                    return "";

                s = excelWorksheet.Cells[row, startingColumn--].Text;
                if (!string.IsNullOrEmpty(s))
                    break;
            }
            return s;

        }

        /*private static string GoUpStopNull(ExcelWorksheet excelWorksheet, int startingRow, int column)
        {
            string s;
            while (true)
            {
                s = excelWorksheet.Cells[startingRow--, column].GetValue<string>();
                if (s != null)
                {
                    break;
                }
            }
            return s;

        }*/

    }
}