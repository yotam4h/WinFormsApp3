using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WinFormsApp3.Backend.Enums;

namespace WinFormsApp3.Backend.Models
{
    [Serializable]
    public class Food : MenuItem
    {
        public ECourse Course { get; set; }
        
        public Food(string name, decimal price, ECourse course) : base(name, price)
        {
            Course = course;
        }

        public override decimal ComputePrice()
        {
            return Price;
        }

        public override string ToString() 
        {
            //return $"{Course} - {Name} - {Price:C}";
            switch(Course)
            {
                case ECourse.Appetizer:
                    return $"{Name} - {Price:C}";
                case ECourse.MainCourse:
                    return $"{Name} - {Price:C}";
                case ECourse.Dessert:
                    return $"{Name} - {Price:C}";
                default:
                    return $"{Name} - {Price:C}";
            }
        }
      
    }
}
