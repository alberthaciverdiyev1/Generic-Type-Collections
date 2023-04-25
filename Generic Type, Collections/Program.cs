using System.Reflection;

namespace Generic_Type__Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedList<int, string> collection = new SortedList<int, string>();
            collection.Add(1995, "PHP");
            collection.Add(1974, "SQL");
            collection.Add(1983, "C++");
            collection.Add(1957, "Lisp");
            collection.Add(1996, "Ruby");
            collection.Add(2009, "Go");
            collection.Add(1950, "Assembly");
            collection.Add(1959, "Cobol");
            collection.Add(2010, "Rust");
            collection.Add(1980, "Ada");
            collection.Add(1991, "Python");
            collection.Add(1972, "Pascal");
            collection.Add(2014, "Swift"); 


            foreach (var item in collection)
            {
                Console.WriteLine(item.Key +" "+ item.Value);

            }
        }
    }
}