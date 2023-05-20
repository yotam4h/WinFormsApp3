using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Enums;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public class Cocktail : Drink
    {    //common ingredients
        public BitArray IngredientFlags { get; set; }

        //User added ingredients
        public BindingList<string> CustomIngredient { get; set; }

        // //Alcohol type
        public string Alcohol { get; set; }

        public Cocktail(string name, decimal price, string size, string alcohol) : base(name, price, size)
        {
            IngredientFlags = new BitArray(6);
            CustomIngredient = new BindingList<string>();
            Alcohol = alcohol;
        }

        public bool Lime_juice
        {
            get { return IngredientFlags[0]; }
            set { IngredientFlags[0] = value; }
        }

        public bool Soda
        {
            get { return IngredientFlags[1]; }
            set { IngredientFlags[1] = value; }
        }

        public bool Mint
        {
            get { return IngredientFlags[2]; }
            set { IngredientFlags[2] = value; }
        }

        public bool Syrup
        {
            get { return IngredientFlags[3]; }
            set { IngredientFlags[3] = value; }
        }
        public bool Sugar_water
        {
            get { return IngredientFlags[4]; }
            set { IngredientFlags[4] = value; }
        }

        public bool Ice
        {
            get { return IngredientFlags[5]; }
            set { IngredientFlags[5] = value; }
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

        public override decimal ComputePrice()
        {
            Price *= Size switch
            {
                "Small" => 1m,
                "Medium" => 1.5m,
                "Large" => 2m,
                _ => throw new Exception("Invalid size"),
            };
            return Price;
        }
        public override string ToString()
        {
            return $"{Name} - {Size} - {Price:C}";
        }
    }
}