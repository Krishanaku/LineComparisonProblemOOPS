﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonProblemOOPS
{
    public class LineComparison
    {
        public void CalLineComparison()
        {
            Console.WriteLine("Enter the x1 co-ordinate");
            double x1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y1 co-ordinate");
            double y1 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the x2 co-ordinate");
            double x2 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the y2 co-ordinate");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double lengthOfLine = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            Console.WriteLine("The lenght of line using co-ordinate : " + lengthOfLine);
        }
    }
}