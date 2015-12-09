using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConsoleApplication3.Day2
{
    public class WrappingPaperCalculator
    {
        public double CalculateMultiplePaper(List<double[]> data)
        {
            return data.Aggregate<double[], double>(0, (current, measures) => 
                    current + CalculateSinglePaper(measures[0], measures[1], measures[2]));
        }

        public double CalculateSinglePaper(double length, double width, double height)
        {
            double a = length*width;
            double b = width*height;
            double c = height*length;

            return GetSmallestMeasure(a,b,c) + 2*a + 2*b + 2*c;
        }

        private double GetSmallestMeasure(double a, double b, double c)
        {
            var smallest = a < b ? a : b;
            if (c < smallest)
            {
                smallest = c;
            }

            return smallest;
        }
    }
}
