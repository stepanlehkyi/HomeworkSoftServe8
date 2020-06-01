

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*1) Create abstract class Shape with field name and property Name.

Add constructor with 1 parameter and abstract methods Area() and Perimeter(), which can
return area and perimeter of shape;

Create classes Circle, Square derived from Shape with field radius (for Circle) and side (for
Square). Add necessary constructors, properties to these classes, override methods from
abstract class Shape.

a) In Main() create list of Shape, then ask user to enter data of 10 different shapes. Write
name, area and perimeter of all shapes.

b) Find shape with the largest perimeter and print its name.

3) Sort shapes by area and print obtained list (Remember about IComparable)*/
namespace Homework_number_8
{
    class Program
    {
        public static List<Square> GetSquaresFromShapeList(List<Shape> shapes)
        {
            List<Square> squares = new List<Square>();
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is Square)
                {
                    squares.Add((Square)shapes[i]);
                }
            }
            return squares;
        }
        public static List<Circle> GetCirclesFromShapeList(List<Shape> shapes)
        {
            List<Circle> circles = new List<Circle>();
            for (int i = 0; i < shapes.Count; i++)
            {
                if (shapes[i] is Circle)
                {
                    circles.Add((Circle)shapes[i]);
                }
            }
            return circles;
        }
        public static void AddSquareToListOfShape(List<Shape> shapes)
        {
            Console.WriteLine("Enter a name of square, than a side size");
            shapes.Add(new Square(Console.ReadLine(), Convert.ToInt32(Console.ReadLine())));
        }
        public static void AddCircleToListOfShapes(List<Shape> shapes)
        {
            Console.WriteLine("Enter a name of circle, than a radius size");
            shapes.Add(new Circle(Console.ReadLine(), Convert.ToInt32(Console.ReadLine())));
        }
        static void Main(string[] args)
        {
            List<Shape> shapes = new List<Shape>();
           for(int i = 0; i < 5; i++)
            {
                AddSquareToListOfShape(shapes);
            }
           for(int i = 0; i < 5; i++)
            {
                AddCircleToListOfShapes(shapes);
            }
       
           
            foreach (var item in shapes)
            {
                Console.WriteLine(item);
            }
            List<Square> squares = GetSquaresFromShapeList(shapes);
            var maxPerimeter=squares.Max(n=>n.Perimeter());
            for (int i = 0; i < squares.Count; i++)
            {
                if (squares[i].Perimeter() == maxPerimeter)
                {
                    Console.WriteLine("The largest perimeter is in {0}",squares[i].Name);
                }
            }
            List<Circle> circles =GetCirclesFromShapeList(shapes);
            circles.Sort();
        }
    }
}
