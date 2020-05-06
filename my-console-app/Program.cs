using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool PlayAgain = true; 

            while (PlayAgain)
            {


             Console.WriteLine("Vælger du sten, saks eller papir");
                string userChoice = Console.ReadLine();

             Random r = new Random();
             int computerChoice = r.Next(4);

                if (computerChoice == 1)
                {
                    if (userChoice == "sten")
                    {
                        Console.WriteLine("programmede har valgt sten");
                        Console.WriteLine("Der står lige ");                     
                    }
                    else if (userChoice == "papir")
                    {
                        Console.WriteLine("Programmede har valgt papir");
                        Console.WriteLine("Der står lige ");

                    }
                    else if (userChoice == "saks")
                    {
                        Console.WriteLine("Programmede har valgt papir");
                        Console.WriteLine("Der står lige ");
                    }
                    else
                    {
                        Console.WriteLine("Du bliver nødt til at vælge sten, saks eller pair ellers virker det ikke ;(");

                    }

                }

                else if (computerChoice == 2)
                {
                    if (userChoice == "sten")
                    {
                        Console.WriteLine("programmede har valgt papir");
                        Console.WriteLine("haha ej hvor er du dårlig, du taber fordi prgrammede har valgt papir");

                    }
                    else if (userChoice == "papir")
                    {
                        Console.WriteLine("programmede har valgt saks");
                        Console.WriteLine("Du har vist tabt... håber det går bedre en anden gang. ");

                    }
                    else if (userChoice == "saks")
                    {
                        Console.WriteLine("programmede har valgt sten");
                        Console.WriteLine("Du taber. Sådan kan det gå når du vælger det forkerte...");                       
                    }
                    else
                    {
                        Console.WriteLine("Du bliver nødt til at vælge sten, saks eller pair ellers virker det ikke ;(");        
                    }
                }
                else if (computerChoice == 3)
                {
                    if (userChoice == "sten")
                    {
                        Console.WriteLine("programmede har valgt saks");
                        Console.WriteLine("WoW du vandt du må være en legende.");

                    }
                    else if (userChoice == "papir")
                    {
                        Console.WriteLine("programmede har valgt sten");
                        Console.WriteLine("Du må være en af de bedste i verden du vandt!!");

                    }
                    else if (userChoice == "saks")
                    {
                        Console.WriteLine("Programmede vælger papir");
                        Console.WriteLine("Du vandt ej hvor er du heldig er du god.");

                    }
                    else
                    {
                        Console.WriteLine("Du bliver nødt til at vælge sten, saks eller pair ellers virker det ikke ;(");

                    }

                }

                 Console.WriteLine("Har du lyst til at prøve igen?? (Ja/Nej)");
                string loop = Console.ReadLine();
                if (loop == "Ja")
                {
                    PlayAgain = true;
                
                }
                else if (loop =="Nej")
                {
                    PlayAgain = false;

                }
            }

        }
    }

    

}