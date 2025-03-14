namespace ST10027393_Genius_PROG6221_IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of Rectangle and Circle
            Rectangle rectangle = new Rectangle("Rectangle", 5, 10);
            Circle circle = new Circle("Circle", 7);

            // Display details for each shape
            rectangle.Display();
            circle.Display();

            // Optionally, display areas directly
            Console.WriteLine($"Rectangle Area: {rectangle.CalculateArea()}");
            Console.WriteLine($"Circle Area: {circle.CalculateArea()}");

            Console.ReadLine();
        }//main end

        public interface ICalculateArea
        {
            double CalculateArea();
        }//interface end

        public abstract class Shape
        {
            public string Name { get; set; }

            // Constructor to set the name of the shape
            public Shape(string name)
            {
                Name = name;
            }

            // Virtual Display Method that can be overridden by derived classes
            public virtual void Display()
            {
                Console.WriteLine($"Shape: {Name}");
            }
        }//shape class end

        public class Rectangle : Shape, ICalculateArea
        {
            public double Width { get; set; }
            public double Height { get; set; }

            // Constructor to initialize name, width, and height
            public Rectangle(string name, double width, double height) : base(name)
            {
                Width = width;
                Height = height;
            }

            // Calculate the area of the rectangle
            public double CalculateArea()
            {
                return Width * Height;
            }

            // Override the Display method to show additional information
            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Width: {Width}, Height: {Height}, Area: {CalculateArea()}");
            }
        }//rectangle shape calculator

        public class Circle : Shape, ICalculateArea
        {
            public double Radius { get; set; }

            // Constructor to initialize name and radius
            public Circle(string name, double radius) : base(name)
            {
                Radius = radius;
            }

            // Calculate the area of the circle
            public double CalculateArea()
            {
                return Math.PI * Radius * Radius;
            }

            // Override the Display method to show additional information
            public override void Display()
            {
                base.Display();
                Console.WriteLine($"Radius: {Radius}, Area: {CalculateArea()}");
            }
        }//circle area calculator

    }
}
