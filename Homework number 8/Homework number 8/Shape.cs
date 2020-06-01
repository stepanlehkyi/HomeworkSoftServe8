using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework_number_8
{
    public abstract class Shape:IComparable
    {
        private string name;
        public string Name { get { return this.name; } }

        public Shape(string name)
        {
            this.name = name;
        }
        public virtual double Area() 
        {
            return new double();
        }
        public virtual double Perimeter()
        {
            return new double();
        }

        public abstract int CompareTo(object obj);
    }
}
