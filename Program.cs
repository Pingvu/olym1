using System;

namespace olym
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("kurvet? ");
              int kurv = int.Parse(Console.ReadLine());
            while ( kurv < 50 || kurv > 200)
            {
                Console.WriteLine("talen måster vara mellan 50-200, försök igen ");
                kurv = int.Parse(Console.ReadLine());
            }
             Console.WriteLine("Affisch?");
                int aff = int.Parse(Console.ReadLine());
            while ( aff < 50 || aff > 200)
            {
                Console.WriteLine("talen måster vara mellan 50-200, försök igen ");
                aff = int.Parse(Console.ReadLine());
            }
             Console.WriteLine("blad?");
               int blad = int.Parse(Console.ReadLine());
            while ( blad < 50 || blad > 200)
            {
                Console.WriteLine("talen måster vara mellan 50-200, försök igen ");
                blad = int.Parse(Console.ReadLine());
            }
             double convert = Math.Pow (10, -6);
             double area1 = 229*324*convert;
             double area2 = 297*420*2*convert;
             double area3 =  210*297*convert;
             double result = area1*kurv + area2*aff + area3* blad;
             double round = Math.Round(result,4);
             Console.WriteLine("Svar: " + round);



        }
    }
}
