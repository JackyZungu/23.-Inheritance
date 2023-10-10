using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Chef
    {
        public void MackeChicken()
        {
            Console.WriteLine("The chef makes chicken");
        }
        public void MakeSalad()
        {
            Console.WriteLine("The chef make salad");
        }
        public virtual void MakeSpecialDish() 
        {
            Console.WriteLine("The chef make special dish");
        }
    }
}
