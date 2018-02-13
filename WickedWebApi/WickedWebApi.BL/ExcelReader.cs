using System.Linq;
using ClosedXML.Excel;
using WickedWebApi.BL.Models;

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
      
        public static void ReadFromXml(string filePath)
        {
            XLWorkbook wb = new XLWorkbook(filePath);
            IXLWorksheet ws = wb.Worksheets.First();

            IXLTable table = ws.Range(ws.FirstCellUsed(), ws.LastCellUsed()).AsTable();

            /*string s = "";
            table.DataRange.CellsUsed().Count();
            table.DataRange.Rows().ForEach(row =>
            {
                s += "\n";
                row.Cells().ToList().ForEach(cell =>
                {
                    s += cell.GetString()+"\t|||\t";
                });
            });
            if (true)
            {
                
            }*/

            TimeTable orar = new TimeTable();
            IXLCell grupaCell = null;

            #region grupa

            //cauta coloana care contine grupa
            IXLRangeColumn grupaColoana = table.DataRange.FindColumn(column =>
            {
                grupaCell = column.Cells()?.FirstOrDefault(cell => cell.GetString().Equals("Grupa"));
                return grupaCell != null;
                //return column.Cells().Any(cell => cell.GetString().Equals("Grupa"));
            });
            int id = 1;
            //insereaza grupele care apar in excel in orar
            grupaColoana.CellsUsed().Where(cell=>!cell.GetString().Equals("Grupa")).ForEach(cell =>
            {
                orar.Groups.Add(new GroupDto(id++,cell.GetString()));
            });

            #endregion

            table.Range(grupaCell.Address.RowNumber + 1, grupaCell.Address.ColumnNumber + 2,
                table.LastCellUsed().Address.RowNumber, table.LastCellUsed().Address.ColumnNumber)
                .CellsUsed().Where(cell=>!table.Cell(cell.Address.RowNumber,3).IsEmpty()).ForEach(cell =>
                {
                    string[] split = cell.GetString().Split(",".ToCharArray());
                    //Programare prog = new Programare();

                    string materie = split[0];
                    string tipMaterie = split[1];
                    string sala = split[2];
                    string profesor = split[3];

                    

                });


        }


    }
}