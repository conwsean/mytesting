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
        /// The master branch change
        /// </summary>
        static void PrintMeMaster()
        {
            Console.WriteLine("This is an addition on the master branch!");
        }
    }
}
