using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public abstract class MenuItem
    {
        public string Name { get; set; }
        public decimal Price { get; set; }

        protected MenuItem(string name, decimal price)
        {
            Name = name;
            Price = price;
        }

        public abstract decimal ComputePrice();
        public override string ToString()
        {
            return $"{Name} - {Price:C}";
        }
    }
}
