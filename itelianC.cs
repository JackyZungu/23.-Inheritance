using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23.Inheritance
{
    internal class ItalianChef:Chef
    {
        public void MakePaste()
        {
            Console.WriteLine("Makes Paste");
        }
        public override void MakeSpecialDish()
        {
            Console.WriteLine("The chef makes Italianspecials ");
        }
    }
}
