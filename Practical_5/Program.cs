namespace Practical_5
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter your day of birth: ");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your month of birth: ");
            string month = Console.ReadLine();
            zodiacSign(day, month);
        }

        public static void zodiacSign(int day, string month)
        {
            string astroSign = "";

            if (month == "december")
            {

                if (day < 22)
                    astroSign = "Sagittarius";
                else
                    astroSign = "capricorn";
            }

            else if (month == "january")
            {
                if (day < 20)
                    astroSign = "Capricorn";
                else
                    astroSign = "aquarius";
            }

            else if (month == "february")
            {
                if (day < 19)
                    astroSign = "Aquarius";
                else
                    astroSign = "pisces";
            }

            else if (month == "march")
            {
                if (day < 21)
                    astroSign = "Pisces";
                else
                    astroSign = "aries";
            }
            else if (month == "april")
            {
                if (day < 20)
                    astroSign = "Aries";
                else
                    astroSign = "taurus";
            }

            else if (month == "may")
            {
                if (day < 21)
                    astroSign = "Taurus";
                else
                    astroSign = "gemini";
            }

            else if (month == "june")
            {
                if (day < 21)
                    astroSign = "Gemini";
                else
                    astroSign = "cancer";
            }

            else if (month == "july")
            {
                if (day < 23)
                    astroSign = "Cancer";
                else
                    astroSign = "leo";
            }

            else if (month == "august")
            {
                if (day < 23)
                    astroSign = "Leo";
                else
                    astroSign = "virgo";
            }

            else if (month == "september")
            {
                if (day < 23)
                    astroSign = "Virgo";
                else
                    astroSign = "libra";
            }

            else if (month == "october")
            {
                if (day < 23)
                    astroSign = "Libra";
                else
                    astroSign = "scorpio";
            }

            else if (month == "november")
            {
                if (day < 22)
                    astroSign = "scorpio";
                else
                    astroSign = "sagittarius";
            }

            Console.WriteLine($"{day} {month} is {astroSign}.");
        }

    }
}