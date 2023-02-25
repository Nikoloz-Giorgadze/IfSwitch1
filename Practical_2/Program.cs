namespace Practical_2
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 2:");
            Console.WriteLine("Enter first number: ");
            int x = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Enter second number: ");
            int y = Convert.ToInt32((Console.ReadLine()));
            Console.WriteLine("Enter third number: ");
            int z = Convert.ToInt32((Console.ReadLine()));
            if (x + y > z && x + z > y && y + z > x)
            {
                Console.WriteLine("This should be a triangle!");
            }
            else
            {
                Console.WriteLine("This shouldn't be a triangle!");
            }
        }
    }
}