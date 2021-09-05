using System;

namespace Module3Lab
{
    class Program
    {

        static double BigDayPass(double days, double minutes)
        {
            double costDay = 10.00;
            double costMin = 0;
            return costDay * days;
        }
        
        static double TouristPass(double days, double minutes)
        {
            double costday = 0;
            double costMin = 0.20;
            
            double total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += minutes * costMin;
            }

            return total;
        }
        
        static double AdventurerPass(double days, double minutes)
        {
            double costday = 3.0;
            double costMin = 0.10;
            double total = 0;
            for (int i = 0; i < 5; i++)
            {
                total += minutes * costMin;
            }

            total += days * costday;
            
            return total;
        }
        
        
        static void Main(string[] args)
        {
            double days = 0;
            double minutes = 0;
            double adventure = 0;
            double tourist = 0;
            double bigDay = 0;
            
            
            Console.Write("How many days will you be travelling?>");
            Double.TryParse(Console.ReadLine(), out days);
            Console.Write("How many minutes per days will you use?>");
            Double.TryParse(Console.ReadLine(), out minutes);

            adventure = AdventurerPass(days, minutes);
            tourist = TouristPass(days, minutes);
            bigDay = BigDayPass(days, minutes);

            Console.WriteLine($"The Adventure Pass would cost you {adventure:C}");
            Console.WriteLine($"The Tourist Pass would cost you {tourist:C}");
            Console.WriteLine($"The Big Day Pass would cost you {bigDay:C}");

            if (adventure < tourist && adventure < bigDay)
            {
                Console.WriteLine($"You should purchase The Adventure Pass for {adventure:C}");
            } else if (tourist < adventure && tourist < bigDay)
            {
                Console.WriteLine($"You should purchase The Tourist Pass for {tourist:C}");
            } else if (bigDay < adventure && bigDay < tourist)
            {
                Console.WriteLine($"You should purchase The Big Day Pass for {bigDay:C}");
            }



        }
    }
}