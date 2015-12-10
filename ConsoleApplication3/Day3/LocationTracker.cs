using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Day3
{
    public class LocationTracker
    {
        List<string> _coordinatesCounter = new List<string>();

        public int UniqueLocationsCount()
        {
            return this._coordinatesCounter.Count;
        }

        public void Add(Coordinates coordinates)
        {
            var coords = string.Format("{0},{1}", coordinates.X, coordinates.Y);
            if (!this._coordinatesCounter.Contains(coords))
            {
                this._coordinatesCounter.Add(coords);
            }
        }
    }
}
