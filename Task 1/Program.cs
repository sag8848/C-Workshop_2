namespace  Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
    // Declaring the variable name and print it
            String userName = "Sagar Acharya";
            Console.WriteLine(userName);
            
    // Declaring variable name to store in integer  and initializing single digit

    int luckyNumber = 7;
    Console.WriteLine($"The Lucky Number is : {luckyNumber}");
    
    // Declaring String interpolation to print in single line

    Console.WriteLine($"Hello, {userName}! Your Lucky Number is: {luckyNumber}");
        }
    }
}