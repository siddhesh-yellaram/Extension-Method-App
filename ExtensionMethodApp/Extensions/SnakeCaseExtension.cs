using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionMethodApp.Extensions
{
    static class SnakeCaseExtension
    {
        public static string ConvertToSC(this String str)
        {
            int n = str.Length;
            String str1 = "";
            for(int i = 0; i < n; i++)
            {
                if (str[i] == ' ')
                    str1 = str1 + '_';
                else
                    str1 = str1 + Char.ToLower(str[i]);
            }
            return "Snake Case Converted: "+str1;
        }
    }
}
