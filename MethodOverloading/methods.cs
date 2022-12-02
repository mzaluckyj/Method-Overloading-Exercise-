using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverloading
{
    internal class methods
    {
        public static int Add(int a, int b)
        {
        return a + b;
        }

        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }

        public static string Add(int w, int v, bool dollars)
        {
            if (dollars && (w+v !=1))
            {
                return $"{w + v} dollars";
            }
            else if(dollars && (v+w)==1)
            {
                return $"{v + w} dollar";
            }
            else
            {
                return $"{v + w}";
            }
        }
    }
}
