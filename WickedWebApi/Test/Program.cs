using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WickedWebApi.BL;
namespace Test
{
    /// <summary>
    /// The program.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// The main.
        /// </summary>
        /// <param name="args">
        /// The args.
        /// </param>
        private static void Main(string[] args)
        {
            ExcelReader.ReadFromXml("C:\\Users\\Ferret\\Desktop\\Orare\\Orara_sem_I-2017-2018_V9.xlsx");

        }
    }
}
