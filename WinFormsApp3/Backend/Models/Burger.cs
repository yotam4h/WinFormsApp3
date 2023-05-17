using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Enums;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public class Burger : MenuItem
    {
        // Free toppings
        public bool Tomatoe { get; set; }
        public bool Lettuce { get; set; }
        public bool Onion { get; set; }
        public bool Pickle { get; set; }
        // Paid toppings
        public BindingList<(string topping, decimal price)> PaidToppings { get; set; }
        // Meat Type
        public EMeatType MeatType { get; set; }

        public Burger(string name, decimal price) : base(name, price)
        {
            PaidToppings = new BindingList<(string topping, decimal price)>();
        }

        public void AddTopping(string topping, decimal price)
        {
            PaidToppings.Add((topping, price));
        }

        public void RemoveTopping(string topping)
        {
            foreach (var item in PaidToppings)
            {
                if (item.topping == topping)
                {
                    PaidToppings.Remove(item);
                    break;
                }
            }
        }

        public override decimal ComputePrice()
        {
            foreach (var item in PaidToppings)
            {
                Price += item.price;
            }
            return Price;
        }

        public override string ToString()
        {
            string paidtoppings = "";
            foreach (var item in PaidToppings)
            {
                paidtoppings += item.topping + ", ";
            }
            string freeToppings = "";
            if (Tomatoe)
            {
                freeToppings += "Tomatoe, ";
            }
            if (Lettuce)
            {
                freeToppings += "Lettuce, ";
            }
            if (Onion)
            {
                freeToppings += "Onion, ";
            }
            if (Pickle)
            {
                freeToppings += "Pickle, ";
            }
            return $"{Name} - {freeToppings} - {paidtoppings} - {Price:C}";

        }

    }
}
