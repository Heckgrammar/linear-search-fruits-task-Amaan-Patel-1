namespace LinearSearchFruitsTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] fruits = { "banana", "apple", "orange", "pear", "grape", "pineapple" };
            Console.WriteLine("Please enter the name of the fruit you would like to find:"); 

            string fruitToFind = Console.ReadLine(); 

            bool isFruitFound = LinearSearch(fruits, fruitToFind); 

            if (isFruitFound) 

            { 

                Console.WriteLine("True"); 

            } 

            else 

            { 

                Console.WriteLine("False"); 

            } 

        } 

        static bool LinearSearch(string[] fruitArray, string fruitToFind) 

        { 

            // Loop through each fruit in the array 

            for (int index = 0; index < fruitArray.Length; index++) 

            { 

                // Check if the current fruit matches the fruit we are looking for 

                if (fruitArray[index].Equals(fruitToFind, StringComparison.OrdinalIgnoreCase)) 

                { 

                    return true; // Fruit found 

                } 

            } 

            return false; // Fruit not found 
            // Your program should:
            // Ask the user what word they would like to find
            // Output the message True if the word is found
            // Output the message False if the word is not found
            
            // You must write your own linear search routine and not use any built-in fuctions available in C#
            // You should use meaningful variable names
        }
    }
}
