using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WickedWebApi.BL.Logger
{
    public class Logger
    {
        public void Info(string text)
        {
            Console.WriteLine(text);
        }

        public void Error(string errorMessage)
        {
            Console.WriteLine(errorMessage);
        }
    }
}
