using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3.Day3
{
    public class Coordinates
    {
        private int _x;
        private int _y;
        public Coordinates(int x, int y)
        {
            this._x = x;
            this._y = y;
        }

        public int X
        {
            get { return this._x; }
            set { this._y = value; }
        }
        public int Y
        {
            get { return this._y; }
            set { this._y = value; }
        }
    }
}
