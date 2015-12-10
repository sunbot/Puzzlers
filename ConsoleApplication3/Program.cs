using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApplication3.Day1;
using ConsoleApplication3.Day2;
using ConsoleApplication3.Day3;

namespace ConsoleApplication3
{
    class Program
    {
        private static void Main(string[] args)
        {
            //Day 1
            var floorAdder = new FloorAdder();
            int floor = floorAdder.CalculateFloor(
                @"C:\Users\Janda\Documents\GitHubVisualStudio\AdventOfCode\ConsoleApplication3\ConsoleApplication3\Day1\adventofcode.txt");
            Console.WriteLine(floor);

            //Day 2
            var file =
                File.ReadAllLines(
                    @"C:\Users\Janda\Documents\GitHubVisualStudio\AdventOfCode\ConsoleApplication3\ConsoleApplication3\Day2\WrappingPaper.txt");
            var wrappingPaperParser = new WrappingPaperMeasurementParser();
            var result = wrappingPaperParser.ParseLines(file);

            var wrappingPaperCalculator = new WrappingPaperCalculator();
            double wrappingPaperSize = wrappingPaperCalculator.CalculateMultiplePaper(result);

            Console.WriteLine(wrappingPaperSize);

            //Day 3
             var directions = File.ReadAllText(@"C:\Users\Janda\Documents\GitHubVisualStudio\AdventOfCode\ConsoleApplication3\ConsoleApplication3\Day3\directions.txt");
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
