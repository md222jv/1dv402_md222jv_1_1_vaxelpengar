using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1DV402.S1.L01A
{
    class Program
    {
        static void Main(string[] args)
        {
            //deklarera variabler
            double totalSum;
            int roundedSum;
            double roundedAmount;
            int payedSum;
            int change;
            int number500;
            int number100;
            int number50;
            int number20;
            int number10;
            int number5;
            int number1;

            while (true)
            {
                //läs in totalsumma
                while (true)
                {
                    Console.Write("Ange totalsumma: ");
                    try
                    {
                        totalSum = double.Parse(Console.ReadLine());
                        if (totalSum >= 1)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Totalsumman är för liten. Köpet kunde inte genomföras");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Totalsumman måste vara ett heltal");
                    }
                }

                //runda av belopp
                roundedSum = (int)Math.Round(totalSum);

                //läs in erhållet belopp   
                while (true)
                {
                    Console.Write("Ange erhållet belopp: ");
                    try
                    {
                        payedSum = int.Parse(Console.ReadLine());
                        if (payedSum >= roundedSum)
                        {
                            break;
                        }
                        else
                        {
                            Console.WriteLine("Erhållet belopp är för litet. Köpet kunde inte genomföras");
                        }
                    }
                    catch
                    {
                        Console.WriteLine("Erhållet belopp är felaktigt");
                    }
                }

                //räkna ut växel
                change = payedSum - roundedSum;
                roundedAmount = roundedSum - totalSum;

                //skriv ut resultat

                Console.WriteLine("\nKVITTO");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("Totalt:              {0}", totalSum);
                //if (roundedAmount > 0)
                {
                    Console.WriteLine("Öresavrundning:      {0:N2}", roundedAmount);
                }
                Console.WriteLine("Att betala:          {0}", roundedSum);
                Console.WriteLine("Kontant:             {0}", payedSum);
                Console.WriteLine("Tillbaka:            {0}", change);
                Console.WriteLine("-------------------------------------");


                //Dela växel i sedlar och mynt
                number500 = change / 500;
                change = change % 500;
                number100 = change / 100;
                change = change % 100;
                number50 = change / 50;
                change = change % 50;
                number20 = change / 20;
                change = change % 20;
                number10 = change / 10;
                change = change % 10;
                number5 = change / 5;
                change = change % 5;
                number1 = change;

                //Skriv ut den beräknade växeln
                if (number500 > 0)
                {
                    Console.WriteLine("500-lappar:      {0}", number500);
                }
                if (number100 > 0)
                {
                    Console.WriteLine("100-lappar:      {0}", number100);
                }
                if (number50 > 0)
                {
                    Console.WriteLine("50-lappar:       {0}", number50);
                }
                if (number20 > 0)
                {
                    Console.WriteLine("20-lappar:       {0}", number20);
                }
                if (number10 > 0)
                {
                    Console.WriteLine("10-kronor:       {0}", number10);
                }
                if (number5 > 0)
                {
                    Console.WriteLine("5-kronor:        {0}", number5);
                }
                if (number1 > 0)
                {
                    Console.WriteLine("1-kronor:        {0}", number1);
                }


                //felhantering
                Console.WriteLine("Tryck valfri tangent för ny beräkning - Esc avslutar");
                ConsoleKeyInfo info = Console.ReadKey();
                if (info.Key == ConsoleKey.Escape)
                {
                    return;
                }
            }
        }
    }
}
