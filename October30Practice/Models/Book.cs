using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October30Practice.Models
{
    internal class Book : Product
    {
        public string AuthorName { get; set; }
        public uint PageCount { get; set; }



        public Book(string name, decimal price, int count, string authorName, uint pageCount)
        {
            Id = ++_id;
            Name = name;
            Price = price;
            Count = count;
            AuthorName = authorName;
            PageCount = pageCount;
        }

        public override void Sell()
        {
            if (Count == 0) 
            {
                Console.WriteLine($"Stock of {Name} book is depleted!");
                return;
            }
            Count -= 1;
            TotalIncome += Price;
        }

        public override string ShowInfo()
        {
            return ($"{Name} with {PageCount} pages is written by {AuthorName} with {Count} remaining in stock. Income: {TotalIncome}");
        }

    }
}
