using System;
namespace OOPLabo
{
    class DateTimeExercises
    {

        public static void DayOfWeekProgram()
        {
            Console.WriteLine("Welke dag?");
            int dag = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welke maand?");
            int maand = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welk jaar?");
            int jaar = Convert.ToInt32(Console.ReadLine());
            DateTime gekozenDatum = new DateTime(jaar,maand,dag);
            Console.WriteLine($"{gekozenDatum.ToString("d")} is een {gekozenDatum.ToString("dddd")}.");
        }
        public static void Ticks2000Program()
        {
            DateTime start = new DateTime(2000, 1, 1);
            DateTime currentTime = DateTime.Now;
            long ticks = currentTime.Ticks - start.Ticks;
            Console.WriteLine($"Sinds {start.ToString("d")} zijn er {ticks} ticks voorbijgegaan.");
        }
        public static void LeapYearProgram()
        {
            int counter = 0;
            for (int year = 1800; year <= 2020; year++)
            {
                if (DateTime.IsLeapYear(year))
                {
                    counter+=1;
                }
            }
            Console.WriteLine($"Er zijn {counter} schrikkeljaren tussen 1800 en 2020.");
        }
        public static void ArrayTimerProgram()
        {
            DateTime start = DateTime.Now;
            int[] array = new int[1000000];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = i;
            }
            DateTime end = DateTime.Now;
            Console.WriteLine($"Het duurt {end.Millisecond - start.Millisecond} milliseconden om een array van een miljoen elementen aan te maken en op te vullen met opeenvolgende waarden.");
        }
        public static void BirthdayProgram()
        {
            int counter = 0;
            DateTime start = DateTime.Now;
            Console.WriteLine("Dag van je verjaardag?");
            int day = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Welke maand verjaard je?");
            int month = Convert.ToInt32(Console.ReadLine());

            while (start.Day != day || start.Month != month || counter == 0)
            {
                start = start.AddDays(1);
                counter++;
            }
            Console.WriteLine($"Er zijn nog {counter} dagen tot je verjaardag.");
        }
        public static void ShowSubmenu()
        {
            Console.WriteLine("Dit is een submenu");
            Console.WriteLine("1. H10-dag-van-de-week");
            Console.WriteLine("2. H10-ticks-sinds-2000");
            Console.WriteLine("3. H10-schrikkelteller");
            Console.WriteLine("4. H10-simpele-timing");
            Console.WriteLine("5. H10-verjaardag-v2");
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
                        DateTimeExercises.DayOfWeekProgram();
                        break;
                    case 2:
                        DateTimeExercises.Ticks2000Program();
                        break;
                    case 3:
                        DateTimeExercises.LeapYearProgram();
                        break;
                    case 4:
                        DateTimeExercises.ArrayTimerProgram();
                        break;
                    case 5:
                        DateTimeExercises.BirthdayProgram();
                        break;
                    default:
                        Console.WriteLine("Dit getal stelt geen oefening voor.");
                        break;
                }
            }

        }
        }
}
