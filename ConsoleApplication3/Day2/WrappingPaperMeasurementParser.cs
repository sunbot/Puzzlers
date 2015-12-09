using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Day2
{
    public class WrappingPaperMeasurementParser
    {
        public List<double[]> ParseLines(string[] lines)
        {
            var data = lines.
                Select(line => 
                    line.Split('x')).
                    Select(ConvertToDoubles).
                    ToList();

            return data;
        }

        private double[] ConvertToDoubles(String[] measurements)
        {
            var measurementDbl = new double[3];

            for (int i = 0; i < 3; i++)
            {
                measurementDbl[i] = double.Parse(measurements[i]);
            }
            return measurementDbl;
        }
    }
}
