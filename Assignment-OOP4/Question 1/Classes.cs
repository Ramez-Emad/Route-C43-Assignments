using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Assignment_OOP4.Question_1
{
    class Circle : Icircle
    {
        public double Radius { get; set; }
        public double Area { get; set; }
        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Circle with radius: {Radius} has an area of: {Area}");
        }
    }
    class Rectangle : Irectangle
    {
        public double Length { get; set; }
        public double Width { get; set; }
        public double Area { get; set; }

        public void DisplayShapeInfo()
        {
            Console.WriteLine($"Rectangle with length: {Length} and width: {Width} has an area of: {Area}");
        }
    }
}
