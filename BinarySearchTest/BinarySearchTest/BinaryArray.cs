using System;
namespace BinarySearchTest
{
    public class BinaryArray
    {
        private int[] data;
        private static Random generator = new Random();

        public BinaryArray(int size)
        {
            //initialise data variable with new array size;
            data = new int[size];

            //Fill data with random integers
            for (int i = 0; i < size; ++i)
            {
                data[i] = generator.Next(10, 100);
            }
            //Sort the data array
            Array.Sort(data);
        }

        public int BinarySearch(int searchElement)
        {
            int low = 0;  //low bound of search
            int high = data.Length;  //high bound of search
            int middle = (low + high) / 2;
            int location = -1; //will remain -1 if value not found

            do //loop to search for element
            {
                //Display remaining elements of the Array
                Console.Write(RemainingElements(low, high));

                //output spaces for alignment
                for (int i = 0; i < middle; ++i)
                    Console.Write("  ");

                Console.WriteLine("Middle is: {0}", data[middle]);  //Indicate current middle

                //if the element is found at the middle
                if (searchElement == data[middle])
                {
                    location = middle;
                }
                else if (searchElement < data[middle]) //if middle element is too high
                {
                    high = middle - 1;
                }
                else      //if middle element is too low
                {
                    low = middle + 1;
                }

                middle = (low + high + 1) / 2; //recalculate middle
            } while ((low <= high) && (location == -1));

            //return location of search Key
            return location; 
        }
        //End BinarySearch method

        public string RemainingElements(int low, int high)
        {
            string temporary = string.Empty;

            //output spaces for alignment to temporary string
            for (int i = 0; i < low; ++i)
                temporary += "  ";

            //output elements in the array to the temporary string
            for (int i = low; i < high; ++i)
            {
                temporary += data[i] + " ";
            }

            //add new line character and return string, string prints in BinarySearch function line 33
            temporary += "\n";
            return temporary;
        }
        //End RemainingElements function

        public override string ToString()
        {
            Console.WriteLine("Data Length is {0}", data.Length);
            return RemainingElements(0, data.Length);  //Length measures from 1 but the array indexes from 0
        }
    }
}
