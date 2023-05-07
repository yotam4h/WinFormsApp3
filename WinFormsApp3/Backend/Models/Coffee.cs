using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public class Coffee : Drink
    {
        public string Milk { get; set; }
        public bool Decaf { get; set; }

        public Coffee(string name, decimal price,bool haveIce, string milk, bool decaf) : base(name, price, haveIce)
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
