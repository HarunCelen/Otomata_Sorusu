using System;

namespace Algoritma_1
{
    internal class Program
    {
        static void Varmı(string a, int i, string ifade)
        {


            if (i < ifade.Length)
            {
                if (a[i] == ifade[i])
                {
                    Console.WriteLine("Otomat q" + (i + 1) + " gidiyor");
                    Varmı(a, i + 1, ifade);



                }
                else
                {
                    Console.WriteLine("Otomat q5 gidiyor");
                }




            }




        }
        static void Main(string[] args)
        {
            Varmı("abba", 0, "abba");


        }
    }
}
