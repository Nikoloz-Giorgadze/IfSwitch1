namespace Practical_1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 1)");
            Console.WriteLine("Enter integer number: ");
            int a = Convert.ToInt32((Console.ReadLine()));
            if (a % 2 == 0)
            {
                Console.WriteLine($"Number {a} is even");
            }
            else
            {
                Console.WriteLine($"Number {a} is odd");
            }
        }
    }
}