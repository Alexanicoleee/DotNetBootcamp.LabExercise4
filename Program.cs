using System;

namespace CSharp.LabExercise4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Shape Abstraction");
            IShape circle = new Circle();
            IShape square = new Square();
            IShape rectangle = new Rectangle();
            circle.ComputeArea();
            circle.DisplayArea();
            square.ComputeArea();
            square.DisplayArea();
            rectangle.ComputeArea();
            rectangle.DisplayArea();
            Console.WriteLine("Calculator Abstraction");
            ICalculate add = new Add();
            ICalculate subtract = new Subtract();
            ICalculate multiply = new Multiply();
            ICalculate divide = new Divide();
            add.Calculate();
            add.DisplayAnswer();
            subtract.Calculate();
            subtract.DisplayAnswer();
            multiply.Calculate();
            multiply.DisplayAnswer();
            divide.Calculate();
            divide.DisplayAnswer();
        }
    }

    abstract class Name
    {
        string _shapeName;
        public string ShapeName 
        {
            get => _shapeName;
            set => _shapeName = value ;
        }
    }

    interface IShape
    {
        public void ComputeArea();
        public void DisplayArea();
    }

    class Circle: Name, IShape
    {
        string _shapeName = "Circle";
        decimal area;

        public void ComputeArea()
        {
            decimal radius = 10;
            decimal pi = Convert.ToDecimal(Math.PI);
            area = pi * radius * radius ;
        }

        public void DisplayArea()
        {

            Console.WriteLine($"Area of {_shapeName} is {area}");
        }
    }

    class Square: Name, IShape
    {
        string _shapeName = "Square";
        decimal area;

        public void ComputeArea()
        {
            decimal side = 20;
            area = side * side;
        }

        public void DisplayArea()
        {

            Console.WriteLine($"Area of {_shapeName} is {area}");
        }
    }

    class Rectangle : Name, IShape
    {
        string _shapeName = "Rectangle";
        decimal area;

        public void ComputeArea()
        {
            decimal length = 20;
            decimal width = 10;
            area = length * width;
        }

        public void DisplayArea()
        {

            Console.WriteLine($"Area of {_shapeName} is {area}");
        }
    }

    interface ICalculate
    {
        public void Calculate();
        public void DisplayAnswer();
    }
    

    class Add: ICalculate
    {
        decimal sum;
        int x, y;

        public void Calculate()
        {
            x = 5;
            y = 15;
            sum = x + y;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine($"Sum of {x} + {y} is equal to {sum}");
        }
    }
    class Subtract : ICalculate
    {
        decimal difference;
        int x, y;

        public void Calculate()
        {
            x = 25;
            y = 15;
            difference = x - y;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine($"Difference of {x} - {y} is equal to {difference}");
        }
    }
    class Multiply :  ICalculate
    {
        decimal product;
        int x, y;

        public void Calculate()
        {
            x = 5;
            y = 15;
            product = x * y;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine($"Product of {x} * {y} is equal to {product}");
        }
    }
    class Divide: ICalculate
    {
        decimal qoutient;
        int x, y;

        public void Calculate()
        {
            x = 50;
            y = 5;
            qoutient = x / y;
        }

        public void DisplayAnswer()
        {
            Console.WriteLine($"Qoutient of {x} / {y} is equal to {qoutient}");
        }
    }
}
