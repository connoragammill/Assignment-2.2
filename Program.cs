namespace Assignment_2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {//Main method of execution 
            Console.WriteLine("Select the shape (Circle or Square):");
            string shapeType = Console.ReadLine().ToLower();//ToLower so the user can enter answer in lowercase 
            Shape shape;//creating a variable, shape, that can reference any object derived from the Shape class. 
            if (shapeType == "circle")//If the shape type is a circle 
            { 
                shape = new Circle();//creating a new instance of the Circle class and assigning it to the variable shape 
                Console.WriteLine("Enter the radius of the circle:"); 
                ((Circle)shape).Radius = double.Parse(Console.ReadLine());//assigns the double value (converted from the user's input) to the Radius property of the |Circle| object. 
            } 
            else if (shapeType == "square")//If the shape type is a square
            { 
                shape = new Square(); 
                Console.WriteLine("Enter the side length of the square:"); 
                ((Square)shape).Side = double.Parse(Console.ReadLine());//assigns the double value (converted from the user's input) to the Radius property of the |Square| object. 
            } 
            else 
            { 
                Console.WriteLine("Invalid shape type.");//If user puts something else besides the two shapes 
                return;//Once the user chooses a shape type, then return the next questions 
            }

            Console.WriteLine("Enter the ID of the shape:"); 
            shape.Id = int.Parse(Console.ReadLine());//.Parse used to covert the string to an integer 
            Console.WriteLine("Enter the name of the shape:"); 
            shape.Name = Console.ReadLine();//User inputs shape name 
            Console.WriteLine("Enter the color of the shape:"); 
            shape.Color = Console.ReadLine();//User inputs shape color 
            Console.WriteLine($"The area of the {shape.Name} is: {shape.CalculateArea()}");//$ is used as an interpolation so everything wont be read as a string
        }
    }

    public abstract class Shape
    {//Abstact class can only be used as the base class (parent)
        public int Id { get; set; }//Id property
        public string Name { get; set; }//Name property
        public string Color { get; set; }//Color property
        public abstract double CalculateArea();//Calculate the area 
    }

    public sealed class Circle : Shape
    {//This inherit class is the information for the circle. Sealed means it cant be a base class
        public double Radius { get; set; }//Radius property
        public override double CalculateArea()//Override calculate area for circle 
        { 
            return Math.PI * Radius * Radius;//Return the math for the area of a circle 
        }
    }

    public sealed class Square : Shape
    {//This inherit class is the information for the square. Sealed means it cant be a base class
        public double Side { get; set; }//Side property
        public override double CalculateArea()//Overide calculated area 
        {
            return Side * Side;//Return the math for calculating the area of a square 
        }
    }
}
