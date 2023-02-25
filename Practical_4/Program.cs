namespace Practical_4
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Write your birth year");
            int year = Convert.ToInt32(Console.ReadLine());
            int temp = year % 12;
            switch (temp)
            {
                case 0:
                    Console.WriteLine($"{year} was Monkey year");
                    break;
                case 1:
                    Console.WriteLine($"{year} was Rooster year");
                    break;
                case 2:
                    Console.WriteLine($"{year} was Dog year");
                    break;
                case 3:
                    Console.WriteLine($"{year} was Pig year");
                    break;
                case 4:
                    Console.WriteLine($"{year} was Rat year");
                    break;
                case 5:
                    Console.WriteLine($"{year} was Ox year");
                    break;
                case 6:
                    Console.WriteLine($"{year} was Tiger year");
                    break;
                case 7:
                    Console.WriteLine($"{year} was Rabbit year");
                    break;
                case 8:
                    Console.WriteLine($"{year} was Dragon year");
                    break;
                case 9:
                    Console.WriteLine($"{year} was Snake year");
                    break;
                case 10:
                    Console.WriteLine($"{year} was Horse year");
                    break;
                case 11:
                    Console.WriteLine($"{year} was Goat year");
                    break;
            }
        }
    }
}