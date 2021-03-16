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
            ArrayList arrayList1 = new ArrayList();
            ArrayList arrayList2 = new ArrayList();
            arrayList1.AddRange(array1);
            arrayList2.AddRange(array2);
            foreach(string element in UniqueNamesWithCollections(arrayList1, arrayList2))
            {
                Console.WriteLine(element);
            }
        }
        public static string[] UniqueNamesWithoutCollections(string [] names1, string[] names2)
        {
            int count = 0;
            int namesCount = 0;
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
                    count++;
                    Array.Resize(ref result, count);
                    for (int r = namesCount; r < result.Length; r++)
                    {
                        result[r] = elementOfArr1;
                    }
                    namesCount++;
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
