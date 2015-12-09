using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3.Day1;
using ConsoleApplication3.Day2;

namespace ConsoleApplication3
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Day 1
            var floorAdder = new FloorAdder();
            int floor = floorAdder.CalculateFloor(
                @"c:\users\angela.moyler\documents\visual studio 2013\Projects\ConsoleApplication3\ConsoleApplication3\Day1\adventofcode.txt");
            Console.WriteLine(floor);

            //Day 2
            var file =
                File.ReadAllLines(
                    @"c:\users\angela.moyler\documents\visual studio 2013\Projects\ConsoleApplication3\ConsoleApplication3\Day2\WrappingPaper.txt");
            var wrappingPaperParser = new WrappingPaperMeasurementParser();
            var result = wrappingPaperParser.ParseLines(file);

            var wrappingPaperCalculator = new WrappingPaperCalculator();
            double wrappingPaperSize = wrappingPaperCalculator.CalculateMultiplePaper(result);

            Console.WriteLine(wrappingPaperSize);

            Console.ReadKey();
        }
    }
}
