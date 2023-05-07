using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public abstract class Drink : MenuItem
    {
        public bool HaveIce { get; set; }
        
        protected Drink(string name, decimal price, bool haveIce) : base(name, price)
        {
            HaveIce = haveIce;
        }

        public override abstract decimal ComputePrice();
    }
}
