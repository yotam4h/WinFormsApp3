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
        public bool Tomato { get; set; }
        public bool Lettuce { get; set; }
        public bool Onion { get; set; }
        public bool Pickle { get; set; }
        // Paid toppings
        public BindingList<string> CustomToppings { get; set; }
        // Meat Type
        public string ?MeatType { get; set; }

        public Burger(string name, decimal price) : base(name, price)
        {
            CustomToppings = new BindingList<string>();
        }

        public void AddTopping(string topping)
        {
            CustomToppings.Add(topping);
        }

        public void RemoveTopping(string topping)
        {
            foreach (var item in CustomToppings)
            {
                if (item == topping)
                {
                    CustomToppings.Remove(item);
                    break;
                }
            }
        }

        public override decimal ComputePrice()
        {
            return Price;
        }

        public override string ToString()
        {
            string customToppings = "";
                foreach (var item in CustomToppings)
                {
                        customToppings += item + ", ";   
                }

            // Remove the last comma
            if (customToppings.Length > 2)
            {
                customToppings = customToppings.Remove(customToppings.Length - 2);
            }

            string freeToppings = "";
            if (Tomato)
            {
                freeToppings += "Tomato, ";
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
            // Remove the last comma
            if (freeToppings.Length > 2)
            {
                freeToppings = freeToppings.Remove(freeToppings.Length - 2);
            }
            return $"{Name} - {freeToppings} - {customToppings} - {Price:C}";

        }

    }
}
