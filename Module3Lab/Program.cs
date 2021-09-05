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
            return minutes * costMin;
        }
        
        static double AdventurerPass(double days, double minutes)
        {
            double costday = 3.0;
            double costMin = 0.10;
            return (costday * days) + (costMin * minutes);
        }
        
        
        static void Main(string[] args)
        {
            double days = 0;
            double minutes = 0;
            double adventure = 0;
            
            
            Console.Write("How many days will you be travelling?>");
            Double.TryParse(Console.ReadLine(), out days);
            Console.Write("How many minutes per days will you use?>");
            Double.TryParse(Console.ReadLine(), out minutes);

            
            
        }
    }
}