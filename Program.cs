namespace C_Programming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. hypotenuse calculator program
            Console.WriteLine("Enter Side A");
            double a = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter Side B");
            double b = Convert.ToDouble(Console.ReadLine());

            double c = Math.Sqrt((a * a) + (b * b));

            Console.WriteLine("The hypotenuse is " + c);
        }
    }
}
