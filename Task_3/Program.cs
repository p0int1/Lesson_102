using System;
using System.Collections.Generic;

//Несколькими способами  создайте  коллекцию, в  которой  можно  хранить  только  целочисленные  и 
//вещественные значения, по типу «счет предприятия – доступная сумма» соответственно. 

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Первый способ
            var dict = new Dictionary<int, double>();

            dict.Add(11122233, 1000.5);
            dict.Add(11120033, 10800.5);
            dict.Add(19119931, 10800.41);

            foreach (var item in dict)
            {
                Console.WriteLine(item.Key + " - " + item.Value); 
            }

            Console.WriteLine(new string('-', 10));

            // Второй способ
            var sortedDict = new SortedDictionary<int, double>();

            sortedDict.Add(11122233, 1000.5);
            sortedDict.Add(11120033, 10800.5);
            sortedDict.Add(19119931, 10800.41);

            foreach (var item in sortedDict)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
    }
}
