using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Day3
{
    public class CoordinatesMover
    {
        public CoordinatesMover(Coordinates startingCoordinates)
        {
            this._coordinates = startingCoordinates;
        }
        private Coordinates _coordinates { get; set; } 

        public Coordinates Move(char direction)
        {
            this._coordinates = Add(this._coordinates, _directionKey[direction]);

            return this._coordinates;
        }

        private Coordinates Add(Coordinates a, Coordinates b)
        {
            int x = a.X + b.X;
            int y = a.Y + b.Y;

            return new Coordinates(x, y);
        }

        Dictionary<char, Coordinates> _directionKey = new Dictionary<char, Coordinates>()
        {
            { Direction.East, new Coordinates(1,0)},
            { Direction.West, new Coordinates(-1,0)},
            { Direction.North, new Coordinates(0,-1)},
            { Direction.South, new Coordinates(0,1)},
        };
            
            
    }
}
