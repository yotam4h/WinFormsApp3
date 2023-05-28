using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Enums;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public class Cocktail : Drink
    {   
        //User added ingredients
        public BindingList<string> CustomIngredient { get; set; }

        // //Alcohol type
        public string Alcohol { get; set; }

        public Cocktail(string name, decimal price, string size, string alcohol) : base(name, price, size)
        {
            CustomIngredient = new BindingList<string>();
            Alcohol = alcohol;
        }

        public bool Lime_juice
        {
            get;
            set;
        }

        public bool Soda
        {
            get;
            set;
        }

        public bool Mint
        {
            get;
            set;
        }

        public bool Syrup
        {
            get;
            set;
        }
        public bool Sugar_water
        {
            get;
            set;
        }

        public bool Ice
        {
            get;
            set;
        }

        public void AddIngredient(string ingredient)
        {
            CustomIngredient.Add(ingredient);
        }

        public void RemoveIngredient(string ingredient)
        {
            foreach (var item in CustomIngredient)
            {
                if (item == ingredient)
                {
                    CustomIngredient.Remove(item);
                    break;
                }
            }
        }

        

        public override string ToString()
        {
            string text = Name + " - " + Alcohol;

            // Add ingredients
            if(Lime_juice || Soda || Mint || Syrup || Sugar_water || Ice)
            {
                text += " - ";
            }
            if(Lime_juice)
            {
                text += "Lime juice, ";
            }
            if (Soda)
            {
                text += "Soda, ";
            }
            if (Mint)
            {
                text += "Mint, ";
            }
            if (Syrup)
            {
                text += "Syrup, ";
            }
            if (Sugar_water)
            {
                text += "Sugar water, ";
            }
            if (Ice)
            {
                text += "Ice, ";
            }
            if (CustomIngredient.Count > 0)
            {
                text += string.Join(", ", CustomIngredient);
            }

            // remove last comma
            if(text.EndsWith(", "))
            {
                text = text.Substring(0, text.Length - 2);
            }

            text += $" - {Size} - {Price:C}";

            return text;
        }
    }
}