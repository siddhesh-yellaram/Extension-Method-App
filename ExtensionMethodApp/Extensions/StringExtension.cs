using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp.Extensions
{
    static class StringExtension
    {
        public static string Foo(this String str)
        {
           return "Name: "+str;
        }
    }
}
