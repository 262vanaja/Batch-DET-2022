using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Batch_DET_2022.Interface1;

namespace Batch_DET_2022
{
    internal class book
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public int Qty { get; set; }
        public Author author { get; set; }  //containment

        public override string ToString()
        {
            return $"Book[name={Name},Author={this.author.ToString()},price={Price},qty={Qty}";
        }
    }

    public class TestBook
    {
        public static void Main()
        {
            book b = new book
            {
                Name = "Mastering C#",
                author = new Author { Name = "Mary", EMail = "mary.s", Gender = 'f' },
                Price = 500,
                Qty = 45
            };

            Author alex = new Author { Name = "Roja", EMail = "roja.p", Gender = 'f' };
            book dummyBook = new book { Name = "C#", author = alex, Price = 19, Qty = 99 };
            Console.WriteLine(b.ToString());
        }
    }
}
