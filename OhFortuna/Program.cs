using System;

namespace OhFortuna
{
    class Program
    {
        static void Main(string[] args)
        {
            int pix = 500;

            Console.WriteLine("Du har 500 pix, satsa minst 50!");
            int userAmountPix = int.Parse(Console.ReadLine());
            pix -= userAmountPix;

            if (userAmountPix >= 50 && userAmountPix <= 500)
            {
                Console.WriteLine("Du satsade: " + userAmountPix);
                Console.WriteLine("Välj ett lyckotal mellan 1 och 6!");
                int userChoice = int.Parse(Console.ReadLine());
                if (userChoice >= 1 && userChoice <= 6)
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
                        Console.WriteLine("En tärning visade rätt. Du får dubbla insatsen, dvs: " + userAmountPix * 2);
                        pix += (userAmountPix * 2);
                        Console.WriteLine("Nu har du: " + pix);
                    }
                    else if (userChoice == dice1number && userChoice == dice2number || userChoice == dice1number && userChoice == dice3number || userChoice == dice2number && userChoice == dice1number || userChoice == dice2number && userChoice == dice3number || userChoice == dice3number && userChoice == dice1number || userChoice == dice3number && userChoice == dice2number) //
                    {
                        Console.WriteLine("Två tärningar visade rätt, du får tre gånger insatsen, dvs: " + userAmountPix *3);
                        pix += (userAmountPix * 3);
                    }
                    else if (userChoice == dice1number && userChoice == dice2number && userChoice == dice3number)
                    {
                        Console.WriteLine("Alla tärningar visade rätt! Du får fyra gånger insatsen, dvs: " + userAmountPix * 4);
                        pix += (userAmountPix * 4);
                        Console.WriteLine("Det du har kvar nu är: " + pix);
                    }
                }
                else
                {
                    Console.WriteLine("Välj något mellan 1 och 6!");
                }
            }
            else
            {
                Console.WriteLine("Du måste välja mellan 50 och 100!");
                userAmountPix = int.Parse(Console.ReadLine());
            }
        }
    }
}
