using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_8
{
    class Circle : Shape, IComparable
    {
        private int radius;
        public int Radius { get { return this.radius; } }
        public Circle(string name, int  radius):base(name)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            double area = Math.PI * Math.Pow(radius, 2);
            return area;
        }
        public override string ToString()
        {
            return $"Name of circle - {Name}, radius = {this.radius}, area = {Area()}";
        }

        public override int CompareTo(object obj)
        {
            if (obj == null)
                return 1;
            Circle circle = obj as Circle;
            if (circle != null)
            {
                return this.Area().CompareTo(circle.Area());
            }
            else
            {
                throw new Exception("Can't cast to Circle class");
            }
        }
    }
}
