namespace Task_6;

class Program
{
    static void Main(string[] args)
    {
        // Create a List<string> containing 3 favorite fruits
        List<string> fruits = new List<string> { "Mango", "Apple", "Banana" };

        // Add a new fruit to the list
        fruits.Add("Orange");

        // Remove one fruit from the list
        fruits.Remove("Apple");

        // Print all fruits using foreach loop
        Console.WriteLine("Fruits in the list:");
        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }

        // Create a Dictionary<int, string> with fruit IDs and names
        Dictionary<int, string> fruitDictionary = new Dictionary<int, string>
        {
            { 1, "Mango" },
            { 2, "Banana" },
            { 3, "Orange" }
        };

        // Add a new entry to the dictionary
        fruitDictionary.Add(4, "Grapes");

        // Print all key-value pairs
        Console.WriteLine("\nFruit Dictionary:");
        foreach (KeyValuePair<int, string> entry in fruitDictionary)
        {
            Console.WriteLine($"ID: {entry.Key}, Fruit: {entry.Value}");
        }
    }
}