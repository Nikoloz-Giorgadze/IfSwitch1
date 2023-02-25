namespace Practical_3
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Practical 3:");
            Console.WriteLine("Enter number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"The pow of the entered number is: {Math.Pow(number, 2)}");

        }
    }
}