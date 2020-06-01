using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_8
{
    class Square:Shape
    {
        private int side;
        public int Side { get { return this.side; } }
        public Square(string name,int side) : base(name)
        {
            this.side = side;
        }
        public override double Perimeter()
        {
            double perimeter = side * 4;
            return perimeter;
        }
        public override string ToString()
        {
            return $"Name of square - {Name}, side = {this.side}, perimeter = {Perimeter()}";
        }
        public override int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Square square = obj as Square;
            if (square != null)
            {
                return this.Perimeter().CompareTo(square.Perimeter());
            }
            else
            {
                throw new Exception("Can't cast to Square class");
            }
        }

    }
}
