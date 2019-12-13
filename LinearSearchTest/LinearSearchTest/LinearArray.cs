using System;
namespace LinearSearchTest
{
    public class LinearArray
    {
        private int[] data;
        private static Random generator = new Random();

        //create array of given size and fill with random integers
        public LinearArray(int size)
        {
            data = new int[size];
            for (int i = 0; i < size; ++i)
            {
                data[i] = generator.Next(10, 100);
            }

        }

        public int LinearSearch(int searchKey)
        {
            for (int index = 0; index < data.Length; ++index)
            {
                //if data matches searchKey return index of integer
                if (data[index] == searchKey)
                    return index;
            }

            //searchKey not found in data
            return -1;
        }

        public override string ToString()
        {
            //Empty string
            string temporary = string.Empty;

            //For each int in data, add the int and a space to the empty temporary string
            foreach (int i in data)
            {
                temporary += i + " ";
            }
            temporary += "\n";  //Add a new line at the end of the string

            //return temporary string
            return temporary;
            
        }
    }
}
