using System;

namespace LinearSearchTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            //Variables for searchInt and index when found.
            int searchInt;
            int position;

            //Create an Array using the class function, then display the Array
            LinearArray searchArray = new LinearArray(10);
            Console.WriteLine(searchArray);

            //Get user to input an integer to search for
            Console.WriteLine("Please Enter an integer value (-1 to quit): ");
            searchInt = Convert.ToInt32(Console.ReadLine());

            while (searchInt != -1)
            {
                //Call the search function from the LinearSearch clas
                position = searchArray.LinearSearch(searchInt);

                //Print result
                if (position != -1)
                    Console.WriteLine("The integer {0} was found at index {1}.\n",
                        searchInt, position);
                else
                    Console.WriteLine("The integer {0} was not found.\n", searchInt);

                //Ask again for user input
                Console.WriteLine("Please Enter an integer value (-1 to quit): ");
                searchInt = Convert.ToInt32(Console.ReadLine());

            }
            
        }
    }
}
