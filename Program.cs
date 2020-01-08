using System;

namespace ReverserArrayUtenNr2Array
{
    class Program
    {
        static void Main(string[] args)
        {
            Program a = new Program();
            a.ReverserTabell();
        }
        /// <summary>
        /// reverserer en tabell uten å lage en ekstra tabell.
        /// </summary>
        void ReverserTabell()
        {
            int størrelse = 10;
            int[] tabell = new int[størrelse];

            //Skriv inn egne verdier 
            for (int i = 0; i < størrelse; i++)
            {
                /*Hvis man vil skrive inn egne verdier til tabellen i det man starter
                 * 
                  Console.WriteLine("Skriv inn tabell elementet [" + i + "]:");
                  tabell[i] = int.Parse(Console.ReadLine());
                 *
                */
                tabell[i] = i;
            }
            //Viser tabellen før reverseringenn
            visTabell(størrelse, tabell);


            //Variabler for å kunne reversere uten tabell nr2
            int første = 0, siste = størrelse - 1, temp;
            //Loop for reversering
            while (første < siste)
            {
                //Tar vare på første element
                temp = tabell[første];
                //Erstatter første posisjon med siste
                tabell[første] = tabell[siste];
                //Erstatter siste posisjon med den som ble tatt vare på (første)
                tabell[siste] = temp;
                //inkrementerer første og minsker siste posisjon
                første++;
                siste--;
            }
            //Viser tabellen etter reverseringen
            visTabell(størrelse, tabell);

            //Pause
            Console.ReadLine();
        }
        
        /// <summary>
        /// Printer ut tabellen med en loop
        /// </summary>
        /// <param name="størrelse"></param>
        /// <param name="tabell"></param>
        void visTabell(int størrelse, int[] tabell)
        {
            for (int i = 0; i < størrelse; i++)
            {
                Console.Write(tabell[i] + " ");
            }
        }
    }
}
