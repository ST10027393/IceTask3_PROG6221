namespace ST10027393_Genius_PROG6221_IceTask3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
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




    }
}
