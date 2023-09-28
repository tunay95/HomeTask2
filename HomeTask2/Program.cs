using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            int n = Convert.ToInt32(Console.ReadLine());
            int i = 1;
            Console.WriteLine("Yaxin  2 lik quvvetler : ");
            do
            {
                i *= 2;
                Console.WriteLine(i);
            }
            while (i < n);
            if (i == n)
            {
                Console.WriteLine("          " + n + "   2-nin quvvetidir . ");
            }
            else
            {
                Console.WriteLine("          " + n + "   2-nin quvveti deyil !! ");
            }





            // Task 2

            //int count = 0;           //bolenlerin sayi
            //int n = Convert.ToInt32(Console.ReadLine());
            //if (n <= 0)
            //{
            //    Console.WriteLine(" Daxil etdiyiniz Eded Ne Sadedir Ne Murekkeb !! ");
            //}
            //else
            //{

            //    for (int i = 2; i <= n + 1; i++)
            //    {
            //        if (n % i == 0)          //i->bolen
            //        {
            //            count++;

            //        }

            //    }
            //    if (count == 1)
            //    {
            //        Console.WriteLine(" Eded Sade Ededdir.  Bolenlerin sayi : " + count);
            //    }
            //    else
            //    {
            //        Console.WriteLine(" Eded Murekkeb Ededdir.  Bolenlerin sayi: " + count);
            //    }
            // }
        }
    }
}










