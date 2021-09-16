using System;
using System.Threading;

namespace OhFortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            int pix = 500;

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("*** VÄLKOMMEN ***");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("*** VÄLKOMMEN ***");
            Thread.Sleep(1000);
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("*** VÄLKOMMEN ***");
            Thread.Sleep(1000);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write('.');Thread.Sleep(500); Console.Write('.'); Thread.Sleep(500); Console.Write('.'); Thread.Sleep(500);
            Console.WriteLine();

            bool done = false;
            while (!done && pix > 0)
            {
                Console.WriteLine("Vill du spela en runda till? y/n");
                string answer = Console.ReadLine();
                if (answer == "n" || pix < 0)
                {
                    Console.WriteLine("Välkommen åter.");
                    done = true;
                }
                else if(answer == "y" && pix > 50)
                {
                    //int pix = 500;

                    Console.WriteLine($"Du har {pix} pix, satsa minst 50!");
                    int userSatsning = int.Parse(Console.ReadLine());
                    pix -= userSatsning;

                    Console.WriteLine("Du satsade: " + userSatsning);
                    Console.WriteLine("Välj ett lyckotal mellan 1 och 6!");
                    int userChoice = int.Parse(Console.ReadLine());
                    if (userChoice >= 1 && userChoice <= 6) // while
                    {
                        Console.WriteLine("Du valde: " + userChoice);

                        Random dice1 = new Random();
                        int dice1number = dice1.Next(1, 7);

                        Random dice2 = new Random();
                        int dice2number = dice1.Next(1, 7);

                        Random dice3 = new Random();
                        int dice3number = dice1.Next(1, 7);
                        Console.WriteLine($"Tärningarna visar {dice1number}, {dice2number} och {dice3number}");

                        if (userChoice != dice1number && userChoice != dice2number && userChoice != dice3number)
                        {
                            Console.WriteLine("Ingen tärning visade ditt lyckotal :(");
                            Console.WriteLine("Du har: " + pix);
                        }
                        else if (userChoice == dice1number || userChoice == dice2number || userChoice == dice3number)
                        {
                            // visas även om två tärningar rätt:
                            Console.WriteLine("En tärning visade rätt. Du får dubbla insatsen, dvs: " + userSatsning * 2);
                            pix += (userSatsning * 2);
                            Console.WriteLine("Det du har nu är: " + pix);
                        }
                        else if (userChoice == dice1number && userChoice == dice2number || userChoice == dice1number && userChoice == dice3number || userChoice == dice2number && userChoice == dice1number || userChoice == dice2number && userChoice == dice3number || userChoice == dice3number && userChoice == dice1number || userChoice == dice3number && userChoice == dice2number) // OBS
                        {
                            Console.WriteLine("Två tärningar visade rätt, du får tre gånger insatsen, dvs: " + userSatsning * 3);
                            pix += (userSatsning * 3);
                            Console.WriteLine("Det du har nu är: " + pix);

                        }
                        else if (userChoice == dice1number && userChoice == dice2number && userChoice == dice3number)
                        {
                            Console.WriteLine("Alla tärningar visade rätt! Du får fyra gånger insatsen, dvs: " + userSatsning * 4);
                            pix += (userSatsning * 4);
                            Console.WriteLine("Det du har nu är: " + pix);
                        }
                    }
                    else if(userChoice !>= 1 || userChoice !<= 6)
                    {
                        Console.WriteLine("Välj något mellan 1 och 6!"); // funkar bara en gång
                        //done = true;
                        userChoice = int.Parse(Console.ReadLine());

                        
                    }







                }
            }
        }
    }
}
