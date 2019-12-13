using System;

namespace BinarySearchTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variables for search value and position if found.
            int searchInt;
            int position;

            //create array and output it
            BinaryArray searchArray = new BinaryArray(15);
            Console.WriteLine(searchArray); //Calls the overridden ToString()

            //prompt and input first int from user
            Console.WriteLine("Enter Integer to search for: ");
            searchInt = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            while (searchInt != -1)
            {
                //Call the BinarySearch funtion on the searchArray, passing the searchInt
                position = searchArray.BinarySearch(searchInt);

                //return value of -1 indicates integer was not found.
                if (position == -1)
                    Console.WriteLine("Integer {0} was not found.\n", searchInt);
                else
                    Console.WriteLine("Integer {0} was found at position {1}\n", searchInt, position);

                //Prompt for next int from user
                Console.WriteLine("Enter Integer to search for: ");
                searchInt = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
            }//end while
        }//end main
    }
}
