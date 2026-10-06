namespace  Task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // When we declare a variable with the const keyword in C#,
            // its value is fixed at compile time and cannot be changed later.
            //The compiler is telling you that you cannot assign a new value to PI because it is not a normal variable.
            //Constants are not variables; they are fixed values baked into the program at compile time.
            //Therefore, the left-hand side (Circle.PI) is not something that can be reassigned.
            
            Circle.PI = 3.145;
            Console.WriteLine(Circle.PI);
        }
    }

    class Circle
    { 
        public const double PI = 3.14;
    }
}