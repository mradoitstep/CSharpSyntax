using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSyntax
{
    class Program
    {
        public int globalnaPremenna = 7;

        void TestGlobalnejPremennej()
        {

        }

        static void Main(string[] args)
        {
            const int mojaKonstanta = 4;
            int polomer = 6;
            //polomer = polomer + 1;
            //polomer += 1;
            Console.WriteLine("Povodny polomer {0}", polomer); // vypise 6
            int novyPolomer = polomer++; // novzpolomer je stale 6 po ukonceni prikazu je ale 7 - vypse 6 !!! lebo ho zvzsi ay po operacii -2kroky=novyPomer=polomer a potom +1 ,
            Console.WriteLine("Novy polomer {0}", novyPolomer);
            int zaseNovyPolomer = ++polomer; // najprv zvysi 
            Console.WriteLine("Zase novy polomer{0}", zaseNovyPolomer);

            //pouyitie kalkulatoru
            Kalkulator.Scitaj("4", "5");


            int vysledok = 5;

            switch (vysledok)
            {
                case 2:
                    Console.WriteLine("Vysledok bol 2");
                    break;
                case 3:
                    Console.WriteLine("Vysledok bol 3");
                    break;
                case 4:
                case 5:
                    Console.WriteLine("Vysledok bol 4 aj 5");
                    break;
                

            }


            // 10-20 nebo 40-60 vcetne, a zaroven nesmie byt 16 !
            if (((vysledok >= 10 && vysledok <= 20) || (vysledok >= 40 && vysledok <= 60)) && vysledok !=16);







            Console.ReadLine();

        }
    }
}
