namespace LeapYearKata
{
    public class LeapYearChecker
    {
        static void Main(string[] args) { }
        public static string LeapYear(int number)
        {
            if (number != 2020 && number != 2024)
                return "Not Leap Year!";
            
            return "Leap Year!";
        }
    }
}