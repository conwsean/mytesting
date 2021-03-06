﻿using System;
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
        private static void PrintMe()
        {
            Console.WriteLine("This has been updated by a change to the remote feature branch!");
        }

        /// <summary>
        /// The master branch change - then edited on feature
        /// </summary>
        static void PrintMeMaster()
        {
            Console.WriteLine("This is an addition on the master branch! - then edited to feature");
        }

        /// <summary>
        /// This is me on feature 2
        /// </summary>
        static void PrintFeature2()
        {
            Console.WriteLine("This is a feature 2 addition!");
        }

        /// <summary>
        /// The second addition on the master branch
        /// </summary>
        static void PrintMeMaster2()
        {
            Console.WriteLine("This is a second addition on the master branch");
        }

        static void Blah()
        {
            Console.WriteLine("Just messing about on local master");
        }
    }
}
