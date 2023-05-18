using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Enums;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public class SoftDrink : Drink
    {
        public bool IsCarbonated { get; set; }
        
        public SoftDrink(string name, decimal price, bool isCarbonated, string size) : base(name, price, size)
        {
            IsCarbonated = isCarbonated;
        }

        public override decimal ComputePrice()
        {
            return Price;
        }

        public override string ToString()
        {
            return base.ToString() + " " + IsCarbonated;
        }
    }
}
