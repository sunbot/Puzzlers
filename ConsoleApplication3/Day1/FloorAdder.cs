using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Day1
{
    public class FloorAdder
    {
        public int CalculateFloor(string file)
        {
            var lines = File.ReadAllText(file);

            int floor = 0;
            foreach (var line in lines)
            {
                if (line == ')')
                {
                    floor--;
                }

                if (line == '(')
                {
                    floor++;
                }
            }

            return floor;
        }
    }
}
