using System;

namespace Assignment_2_2
{
    public class CircleCalculation
    {
        public double circleRadius;
        public double circleArea;
        public double circleDiameter;
        public double circleCircumference;

        public double GetRadiusCircle()
        {
            Console.Write("Insert the radius of the circle: ");
            circleRadius = double.Parse(Console.ReadLine());
            return circleRadius;
        }

        public double AreaCircle()
        {
            circleArea = Math.PI * Math.Pow(circleRadius,2);
            return circleArea;
        }

        public double DiameterCircle()
        {
            circleDiameter = 2 * circleRadius;
            return circleDiameter;
        }

        public double CircumferenceCircle()
        {
            circleCircumference = 2 * Math.PI * circleRadius;
            return circleCircumference;
        }
        public bool CheckIfSquareFits(double squareDiagonal)
        {
            if(squareDiagonal < circleDiameter)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }

    public class SquareCalculation
    {
        public double squareSide;
        public double squarePerimeter;
        public double squareArea;
        public double squareDiagonal;

        public double SideSquare()
        {
            Console.Write("Insert the length the side of the square: ");
            squareSide = double.Parse(Console.ReadLine());
            return squareSide;
        }

        public double PerimeterSquare()
        {
            squarePerimeter = 4 * squareSide;
            return squarePerimeter;
        }

        public double AreaSquare()
        {
            squareArea = Math.Pow(squareSide, 2);
            return squareArea;
        }

        public double DiagonalSquare()
        {
            squareDiagonal = squareSide * Math.Sqrt(2);
            return squareDiagonal;
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            CircleCalculation circleCal  = new CircleCalculation();
            SquareCalculation squareCal = new SquareCalculation();

            circleCal.GetRadiusCircle();
            Console.WriteLine("The Area of the Circle is: {0}", circleCal.AreaCircle());
            Console.WriteLine("The Diameter of the Circle is: {0}", circleCal.DiameterCircle());
            Console.WriteLine("The Circumference of the Circle is: {0}", circleCal.CircumferenceCircle());
            
            squareCal.SideSquare();
            Console.WriteLine("The Perimeter of the Square is: {0}", squareCal.PerimeterSquare());
            Console.WriteLine("The Area of the Square is: {0}", squareCal.AreaSquare());
            Console.WriteLine("The Diagonal of the Square is: {0}", squareCal.DiagonalSquare());
            
            if(circleCal.CheckIfSquareFits(squareCal.DiagonalSquare()) == true)
            {
                Console.WriteLine("This square fits perfectly inside the circle.");
            }
            else
            {
                Console.WriteLine("This square doesn't fits inside the circle.");
            }
        }
    }
}
