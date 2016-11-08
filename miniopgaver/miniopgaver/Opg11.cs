using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Miniopgaver
{
    public class Opgave
    {
        public static void Main()
        {
            Opgave5();                    
        }

        public static void Opgave1()
        {
            Debug.WriteLine("Hello");
            Debug.WriteLine("Steen");
        }

        public static void Opgave2()
        {
            int resultat = 12 + 13;
            Debug.WriteLine(resultat);
        }

        public static void Opgave3()
        {
            int reshel = 24 / 5;
            float a = 24;
            float b = 5;
            float reskom = a / b;
            Debug.WriteLine(reshel);
            Debug.WriteLine(reskom);
        }

        public static void Opgave4()
        {
            int vala = -1 + 3 * 5;
            Debug.WriteLine(vala);

            int valb = (24 + 5) % 7;
            Debug.WriteLine(valb);

            float valc = 15 + -4 * 6 / 11;
            Debug.WriteLine(valc);

            float vald = 2 + 10 / 6 * 1 - 7 % 2;
            Debug.WriteLine(vald);
        }

        public static void Opgave5()
        {
            //Console.WriteLine("Indtast første tal: "+ Console.ReadLine());
            Console.WriteLine("Indtast første tal: ");
            int tal1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Indtast næste tal: ");
            int tal2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Resultatet af multiplikation er: {0}", tal1 * tal2);

            Console.ReadKey();
           
        }


    }
}
