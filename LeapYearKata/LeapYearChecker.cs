namespace LeapYearKata
{
    public class LeapYearChecker
    {
        static void Main(string[] args) { }
        public static string LeapYear(int number)
        {
            return number % 4 == 0 ? "Leap Year!" : "Not Leap Year!";
        }
    }
}