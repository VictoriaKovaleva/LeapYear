namespace LeapYearKata
{
    public class LeapYearChecker
    {
        static void Main(string[] args) { }
        public static string LeapYear(int number)
        {
            if (number % 4 == 0)
                return "Leap Year!";
            return "Not Leap Year!";
            
            
        }
    }
}