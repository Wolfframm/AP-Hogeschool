using System;

namespace OOPLabo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welkom bij de demo Objectgeorienteerd Programmeren");
            while (true)
            {
                Console.WriteLine("Topic van de uit te voeren oefeningen");
                Console.WriteLine("1. DateTime");
                Console.WriteLine("2. Properties en access modifiers");
                int number;
                bool gotNumber = int.TryParse(Console.ReadLine(), out number);

                if (!gotNumber)
                {
                    Console.WriteLine("Je hebt geen getal ingevoerd.");
                }
                else
                {
                    switch (number)
                    {
                        case 1:
                            DateTimeExercises.ShowSubmenu();
                            break;
                        case 2:
                            NumberCombination.ShowSubmenu();
                            break;
                        default:
                            Console.WriteLine("Dit getal stelt geen topic voor.");
                            break;
                    }
                }
            }
        }
    }
}
