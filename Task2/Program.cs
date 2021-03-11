using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int i = 0; i < UniqueNamesWithOutCollections().Length; i++)
            {
                Console.WriteLine(UniqueNamesWithOutCollections()[i]);
             } 
            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList();
            foreach(string element in UniqueNamesWithCollections(arr1, arr2))
            {
                Console.WriteLine(element);
            }

        }
        public static string[] UniqueNamesWithOutCollections()
        {
            int count = 0;
            string[] array1 = { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            string[] array2 = { "Dima", "Ivan", "Kate" };
            string[] result = new string[count];
            Boolean isElementExists;
            for (int i = 0; i < array1.Length; i++)
            {
                isElementExists = false;
                for (int j = 0; j < array2.Length; j++)
                {
                    if (array1[i] == array2[j])
                    {
                        isElementExists = true;
                    }                    
                }
                if (isElementExists == false)
                {                                        
                    count++;
                    Array.Resize(ref result, count);
                    Console.WriteLine(result.Length);
                    Console.WriteLine(result[i]);
                    result[count] = array1[i];
                }

            }
            return result;
        }

        public static IList UniqueNamesWithCollections(ArrayList names1, ArrayList names2)
        {
            Boolean isNameExists;
            ArrayList resultList = new ArrayList();
            foreach (string element in names1)
            {
                isNameExists = false;
                foreach (string element2 in names2)
                {
                    if (element.Equals(element2))
                    {
                        isNameExists = true;
                    }
                }
                if (isNameExists == false)
                {
                    resultList.Add(element);
                }
            }
            return resultList;

        }
    }
}
