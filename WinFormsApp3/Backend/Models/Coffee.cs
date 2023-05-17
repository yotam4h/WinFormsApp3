using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Enums;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public class Coffee : Drink
    {
        // maybe add cold\hot, how many espresso shots
        public string Milk { get; set; }
        public bool Decaf { get; set; }

        public Coffee(string name, decimal price,ESize size, string milk, bool decaf) : base(name, price,size)
        {
            Milk = milk;
            Decaf = decaf;
        }

        public override decimal ComputePrice()
        {
            return Price;
        }        
    }
}
