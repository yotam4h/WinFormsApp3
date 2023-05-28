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
        public string Beans { get; set; }
        public string Temp { get; set; }
        public bool Strong { get; set; }

        public Coffee(string name, decimal price, string size, string milk, string beans, string temp, bool strong) : base(name, price ,size)
        {
            Milk = milk;
            Beans = beans;
            Temp = temp;
            Strong = strong;
        } 
        
        public override string ToString()
        {
            //return base.ToString() + " " + Milk;
            /*if(Strong)
                return base.ToString() + " " + Beans + " " + Milk + " " + Strong + " " + Temp;
            else
                return base.ToString() + " " + Beans + " " + Milk + " " + Temp;
*/
            string text = Name + " - ";
            
        }
    }
}
