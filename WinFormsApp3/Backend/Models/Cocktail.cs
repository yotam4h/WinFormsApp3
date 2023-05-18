using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Enums;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public class Cocktail : Drink
    {
        // add cocktail ingredients
        public string Alcohol { get; set; }

        Cocktail(string name, decimal price, string size, string alcohol) : base(name, price, size)
        {
            Alcohol = alcohol;
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
