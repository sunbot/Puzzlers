using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3.Day1;
using ConsoleApplication3.Day2;
using ConsoleApplication3.Day3;
using System.Reflection;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApplication3
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Day 1
            string currentPath = Path.Combine(Directory.GetCurrentDirectory());

            string day1Path = Path.Combine(currentPath, @"Day1\adventofcode.txt");

            var floorAdder = new FloorAdder();
            int floor = floorAdder.CalculateFloor(
                day1Path);
            Console.WriteLine(floor);

            //Day 2
            string day2Path = Path.Combine(currentPath, @"Day2\WrappingPaper.txt");
            var file =
                File.ReadAllLines(
                    day2Path);
            var wrappingPaperParser = new WrappingPaperMeasurementParser();
            var result = wrappingPaperParser.ParseLines(file);

            var wrappingPaperCalculator = new WrappingPaperCalculator();
            double wrappingPaperSize = wrappingPaperCalculator.CalculateMultiplePaper(result);

            Console.WriteLine(wrappingPaperSize);

            //Day 3
            string day3Path = Path.Combine(currentPath, @"Day3\directions.txt");
            var directions = File.ReadAllText(day3Path);
            var startingCoordinates = new Coordinates(0, 0);
            var mover = new CoordinatesMover(startingCoordinates);
            var tracker = new LocationTracker();

            tracker.Add(startingCoordinates);
            foreach (var direction in directions)
            {
                var coords = mover.Move(direction);
                tracker.Add(coords);
            }

            Console.WriteLine(tracker.UniqueLocationsCount());
            Console.ReadKey();
        }
    }
}
