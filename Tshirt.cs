using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
     class Tshirt : Artikel
    {
        private static string[] storlek = new string[] {"S", "M", "L", "XL"  }; 

        public static string Storlek()
        {
            Random random = new Random();
            int index = random.Next(storlek.Length);
            return storlek[index];
        }
    }
}
