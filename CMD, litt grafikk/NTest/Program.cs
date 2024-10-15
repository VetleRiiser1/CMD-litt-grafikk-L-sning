using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace NTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string symbol = "*";


            //oppgave:
            //få dette til å gå evig. ved å bruke en eller annen loop. foreach, while, for

            while (true) { //jeg la til en while(true), fordi det er ingen annen kode som forandrer while true, som gjør at den går for alltid.
            //loop legger til tegn
            for (int i = 0; i < 9; i++)
            {
                Console.WriteLine(symbol);
                //manipulere symbolet for hver runde
                symbol = symbol + "*";
                Thread.Sleep(100);
            }
            //fjerner tegn
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(symbol);
                //manipulere symbolet for hver runde
                if (symbol.Length > 0) //sjekker hvis symbol lengden er større en 0, aka sjekker hvis det er noe å fjerne
                    {
                symbol = symbol.Remove(symbol.Length-1, 1);
                    }
                    Thread.Sleep(100);
            }
            }




            //Console.ReadLine(); Fjerna Console.ReadLine, fordi den kommer aldri til å bli "aktivert"/brukt fordi denne går for alltid.
        }
    }
}

//FORKLARING:
// Jeg la til en while(true) som går for alltid, fordi while(true) kan aldri oppnå's (bli gjort om til falsk) fordi
// det er ikke noe kode som kan gjøre den til false.
//
// Jeg la også til en if statement som sjekker om symbol er større en 0, dette er så den ikke prøver å fjerne en karakter
// fra en tom string, hvis du gjør dette får du ArgumentOutOfRangeException.
