using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyFirstApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is me on the feature branch! Merged into trunk");
        }

        /// <summary>
        /// Feature branch addition
        /// </summary>
        static void PrintMe()
        {
            Console.WriteLine("This was added in the feature branch!");
        }
    }
}
