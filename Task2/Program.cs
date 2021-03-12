using System;
using System.Collections;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "Alex", "Dima", "Kate", "Galina", "Ivan" };
            string[] array2 = { "Dima", "Ivan", "Kate" };
            foreach (string element in UniqueNamesWithoutCollections(array1, array2))
            {
                Console.WriteLine(element);
            } 
            ArrayList arr1 = new ArrayList();
            ArrayList arr2 = new ArrayList();
            arr1.AddRange(new string [] { "Alex", "Dima", "Kate", "Galina", "Ivan" });
            arr2.AddRange(new string[] { "Dima", "Ivan", "Kate" });
            foreach(string element in UniqueNamesWithCollections(arr1, arr2))
            {
                Console.WriteLine(element);
            }
        }
        public static string[] UniqueNamesWithoutCollections(string [] names1, string[] names2)
        {
            int count = 0;
            string[] result = new string[count];
            Boolean isElementExists;
            foreach (string elementOfArr1 in names1)
            {
                isElementExists = false;
                foreach (string elementOfArr2 in names2)
                {
                    if (elementOfArr1.Equals(elementOfArr2))
                    {
                        isElementExists = true;
                    }              
                }
                if (isElementExists == false)
                {
                    Array.Resize(ref result, count);
                    for (int r = 0; r < result.Length; r++)
                    {
                        result[r] = elementOfArr1;
                    }
                    count++;
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
