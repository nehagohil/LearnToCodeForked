using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProblemSolution
{
    internal class AreaOfShapes
    {
        public int getAreaOfSquare(int side)
        {
            int squarearea = side * side;
            return squarearea;
        }

        public int getAreaOfRectangle(int length, int width)
        {
            int reactanglearea = length * width;
            return reactanglearea;
        }

        public double getAreaOfCircle(int radius)
        {
            double circlearea = 3.14 * radius * radius;
            return circlearea;
        }
    }
}
