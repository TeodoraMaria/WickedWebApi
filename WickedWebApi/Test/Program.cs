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
            ExcelReader.ReadGroupDto("C:\\Users\\Ferret\\Desktop\\GrupeStudenti (1).xlsx");

        }
    }
}
