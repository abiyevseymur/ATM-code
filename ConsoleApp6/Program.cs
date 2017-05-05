using System;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Meblegi daxil edin:");
            int pul = Convert.ToUInt16(Console.ReadLine());
            int[] valute = new int[]{ 100, 50, 20, 10, 5, 1 };
            for (int i= 0;i<6;i++)
            {
                int eded;
                if (pul / valute[i] > 0) {
                    eded = pul / valute[i];
                    Console.WriteLine(valute[i]+" AZN "+ eded+ " eded");
                    pul = pul % valute[i];
                }
            }
            Console.Read();
        }
    }
}