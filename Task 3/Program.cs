namespace  Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare and initialize variables of different types
            byte myByte = 255;
            short myShort = 32000;
            int myInt = 42;
            long myLong = 1234567890L;
            float myFloat = 3.14f;
            double myDouble = 3.14159;
            decimal myDecimal = 123.456m;
            char myChar = 'A';
            bool myBool = true;

            // Convert integer value 42 to string
            string intToString = myInt.ToString();

            // Convert string "3.14" to double
            string strValue = "3.14";
            double strToDouble = Convert.ToDouble(strValue);

            // Print all variables with labels
            Console.WriteLine($"byte: {myByte}");
            Console.WriteLine($"short: {myShort}");
            Console.WriteLine($"int: {myInt}");
            Console.WriteLine($"long: {myLong}");
            Console.WriteLine($"float: {myFloat}");
            Console.WriteLine($"double: {myDouble}");
            Console.WriteLine($"decimal: {myDecimal}");
            Console.WriteLine($"char: {myChar}");
            Console.WriteLine($"bool: {myBool}");
            Console.WriteLine($"int to string: {intToString}");
            Console.WriteLine($"string to double: {strToDouble}");  
        }
    }
}

