using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test3
{
    class Book
    {
        public string Author;
        public string Name;
        public int Year;

        public override string ToString()
        {
            return Author + " - " + Name + " - " + Year;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            List<Book> books = new List<Book>()
            {
                new Book(){Author= "Author1",Name="Linq",Year=2020 },
                new Book(){Author= "Author2",Name="C#",Year=2010 },
                new Book(){Author= "Author2",Name="C++",Year=2013 },
                new Book(){Author= "Author1",Name="JS",Year=2011 },
                new Book(){Author= "Author1",Name="C# Linq",Year=2016 }
            };
            Console.WriteLine(string.Join("\n", books));

            Console.WriteLine("________________1_________________");
            Console.WriteLine(string.Join("\n", books.Where(book => book.Name.ToLower().Contains("linq") &&
            DateTime.IsLeapYear(book.Year))));

            Console.WriteLine("________________2_________________");
            string A = "дом автомобиль молния город 1233 *&$";
            Console.WriteLine(string.Join(" ", A.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).
                SelectMany(word => word.ToCharArray()).Distinct().Where(ch => char.IsLetter(ch)).Count()));

            Console.WriteLine("________________3_________________");
            int[] C = new[] { 14, 12, 55, 73, 23, 20, 11, 33, 32 };
            Console.WriteLine(string.Join(" ", C.OrderBy(x => x / 10).ThenBy(x => x % 10)));

            Console.WriteLine("________________4_________________");
            Console.WriteLine(string.Join(Environment.NewLine, books.GroupBy(f => f.Author).Select(g => g.Key + " " + g.Count())));
        }
    }
}
