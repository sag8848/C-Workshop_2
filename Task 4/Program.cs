namespace  Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a single-dimensional integer array with 5 favorite numbers
            int[] favoriteNumbers = { 42, 7, 99, 13, 56 };

            // Sort the array in ascending order
            Array.Sort(favoriteNumbers);
            Console.WriteLine(favoriteNumbers);

            // Reverse the sorted array
            Array.Reverse(favoriteNumbers);
            Console.WriteLine(favoriteNumbers);

            // Print each element using a for loop
            
            Console.WriteLine("Array elements after sort and reverse:");
            for (int i = 0; i < favoriteNumbers.Length; i++)
            {
                Console.WriteLine($"Index {i}: {favoriteNumbers[i]}");
            }

            // Use Array.IndexOf() to find the position of a specific number
            int searchNumber = 99;
            int position = Array.IndexOf(favoriteNumbers, searchNumber);

            Console.WriteLine($"The number {searchNumber} is at index: {position}");
        }    
        }
    }



