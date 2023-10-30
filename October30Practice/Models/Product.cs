using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace October30Practice.Models
{
    internal abstract class Product
    {
        protected static int _id;

        public int Id { get; init; }

        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal TotalIncome { get; set; }

        public abstract void Sell();
        public abstract string ShowInfo();
    }
}
