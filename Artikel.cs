using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Uppgift1
{
    public class Artikel
    {
        private static string[] motiv = new string[]
        {
           "Stone","Rock","Metal","Hard","Leather","Scent","Sweat","Tears","Blood","Demon",
            "Life","Love","Live","Pop","Blues","Country","Dogs","Hurt","Find","Fear",
            "Legend","Myth","Master","Monster","Thriller","Dark","Side","Moon","Bat","Cats"
        };

        

        public static int Pris()
        {
            Random rnd = new Random();
            int pris = rnd.Next(50, 255);
            return pris;

        }

        public static string Motiv()
        {
            Random rnd = new Random();
            int index = rnd.Next(motiv.Length);
            return motiv[index];   
        }
        public static int SnittBetyg()
        {
            Random rnd = new Random();
            int snittbetyg = rnd.Next(1, 10);
            return snittbetyg;
        }

        
        
    }
}
