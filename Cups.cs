using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Uppgift1
{
    class Cups : Artikel
    {

        private static string[] Typ = new string[] {"Fyrkantig", "Runda", "Små muggar" };

        public static string TypAvMugg()
        {
            Random random = new Random();
            int index_ = random.Next(Typ.Length);
            return Typ[index_];

        }

    }
}
