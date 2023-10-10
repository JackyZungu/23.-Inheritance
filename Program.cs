using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Chef chef = new Chef();
            chef.MackeChicken();

            ItalianChef chef1 = new ItalianChef();
            chef1.MackeChicken();
            chef1.MakePaste();
            chef1.MakeSpecialDish();

            Console.ReadLine();
        }
    }
}
