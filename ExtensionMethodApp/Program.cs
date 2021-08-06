using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExtensionMethodApp.Extensions;

namespace ExtensionMethodApp
{
    class Program
    {
        static void Main(string[] args)
        {
            String name = "Siddhesh Yellaram";
            Console.WriteLine(name.Foo());
            Console.WriteLine(name.ConvertToSC());
            Console.ReadLine();
        }
    }
}
