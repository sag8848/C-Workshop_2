namespace  Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a DateTime variable representing your birthdate
            DateTime birthDate = new DateTime(1998, 05, 17); 

            // Create another DateTime variable representing the current date and time
            DateTime currentDate = DateTime.Now;

            // Calculate your age using TimeSpan
            TimeSpan ageSpan = currentDate - birthDate;
            int ageInYears = (int)(ageSpan.Days / 365.25); 

            // Print your birthdate, current date, and age in years
            Console.WriteLine($"Birthdate: {birthDate.ToShortDateString()}");
            Console.WriteLine($"Current Date: {currentDate}");
            Console.WriteLine($"Age in Years: {ageInYears}");

            // Add 10 days to your birthdate and print the resulting date
            DateTime newDate = birthDate.AddDays(10);
            Console.WriteLine($"Birthdate + 10 days: {newDate.ToShortDateString()}");   
        }
    }
}





