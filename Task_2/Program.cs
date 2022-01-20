using System;
using System.Collections.Generic;

//Создайте коллекцию, в которую можно добавлять покупателей и категорию приобретенной ими продукции.
//Из коллекции можно получать категории товаров, которые купил покупатель или по категории определить покупателей. 

namespace Task_2
{
    class Client
    {
        public string Name { get; set; }

        public Client(string name)
        {
            this.Name = name;
        }
    }

    enum Category
    {
        IT, Other
    }

    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<Client, List<Category>> dic = new Dictionary<Client, List<Category>>();

            dic.Add(new Client("Butev"), new List<Category> { Category.IT, Category.Other });
            dic.Add(new Client("Stolpakov"), new List<Category> { Category.Other });

            foreach (KeyValuePair<Client, List<Category>> item in dic)
            {
                Console.Write(item.Key.Name + ": ");
                foreach (var category in item.Value)
                {
                    Console.Write(category + ", ");
                }
                Console.WriteLine();
                Console.WriteLine(new string('-', 10));
            }

            var res = GetClientByCategory(dic, Category.Other);
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }

            Console.ReadKey();
        }

        static List<Client> GetClientByCategory(Dictionary<Client, List<Category>> dic, Category cat)
        {
            List<Client> cl = new List<Client>();
            foreach (var item in dic)
            {
                if (item.Value.Contains(cat))
                {
                    cl.Add(item.Key);
                }
            }
            return cl;
        }
    }
}
