using System;
namespace OOPLabo
{
    class NumberCombination
    {
        public int Number1;
        public int Number2;

        public double Sum()
        {
            double result = (double)Number1 + (double)Number2;
            return result;
        }

        public double Difference()
        {
            double result = (double)Number1 - (double)Number2;
            return result;
        }

        public double Product() {

          double result = (double)Number1 * (double)Number2;
          return result;
        }

        public double Quotient()
        {
            if (Number2 == 0)
            {
                Console.WriteLine("Error, Delen door 0 gaat niet.");
            }
            double result = (double)Number1 / (double)Number2;
            return result;
        }


        public static void DemonstrateOperations()
        {
            NumberCombination pair1 = new NumberCombination();
            pair1.Number1 = 12;
            pair1.Number2 = 34;
            Console.WriteLine("Paar:" + pair1.Number1 + ", " + pair1.Number2);
            Console.WriteLine("Sum = " + pair1.Sum());
            Console.WriteLine("Verschil = " + pair1.Difference());
            Console.WriteLine("Product = " + pair1.Product());
            Console.WriteLine("Quotient = " + pair1.Quotient());
        }

        public static void ShowSubmenu()
        {
            Console.WriteLine("Dit is een submenu");
            Console.WriteLine("1. Demonstrate Operations");
            bool gotNumber;
            int number;
            gotNumber = int.TryParse(Console.ReadLine(), out number);

            if (!gotNumber)
            {
                Console.WriteLine("Je hebt geen getal ingevoerd.");
            }
            else
            {
                switch (number)
                {
                    case 1:
                        NumberCombination.DemonstrateOperations();
                        break;
                    default:
                        Console.WriteLine("Dit getal stelt geen oefening voor.");
                        break;
                }
            }

        }
    }
}
