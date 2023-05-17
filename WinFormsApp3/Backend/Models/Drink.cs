using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Enums;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public abstract class Drink : MenuItem
    {
        public ESize Size { get; set; }

        protected Drink(string name, decimal price, ESize size) : base(name, price)
        {
            Size = size;
        }
    }
}
