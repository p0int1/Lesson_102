using System;
using System.Collections;

//Используя класс SortedList, создайте небольшую коллекцию и выведите на экран значения пар 
//«ключ- значение» сначала в алфавитном порядке, а затем в обратном. 

namespace Addition
{
    class Program
    {
        static void Main(string[] args)
        {
            var sort = new SortedList();
            var revSort = new SortedList(new DescendingComparer());

            sort["First"] = "1st";
            sort["Second"] = "2nd";
            sort["Third"] = "3rd";
            sort["Fourth"] = "4th";

            foreach (DictionaryEntry entry in sort)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
                revSort.Add(entry.Key, entry.Value);

            }

            Console.WriteLine(new string('-', 15));

            foreach (DictionaryEntry entry in revSort)
            {
                Console.WriteLine("{0} = {1}", entry.Key, entry.Value);
            }

            Console.ReadKey();
        }
    }

    public class DescendingComparer : IComparer
    {
        CaseInsensitiveComparer comparer = new CaseInsensitiveComparer();

        public int Compare(object x, object y)
        {
            // Для сортировки по убыванию.
            // Объекты, переданные для сравнения, меняются местами.
            int result = comparer.Compare(y, x);
            return result;
        }
    }
}
