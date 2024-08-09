namespace Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Əgər a və b  ədədləri 2 və 3 - ə bölünürsə, onların 6 - a da bölünməsini müəyyən etmək üçün proqram tərtib etməli

            //Console.WriteLine("a daxil edin");
            //int a = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("b daxil edin");
            //int b = Convert.ToInt32(Console.ReadLine());

            //if (a % 2 == 0 && a % 3 == 0 && b % 2 == 0 && b % 3 == 0)
            //{
            //    if (a % 6 == 0 && b % 6 == 0)
            //    {
            //        Console.WriteLine("Her iki eded 6-ya bolunur.");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Ededlerden biri ve ya her ikisi 6-ya bolunmur.");
            //    }
                
            //}
            //else
            //{
            //    Console.WriteLine("Ededlerden 2 ve 3-a bolunmur.");
            //}


            //Verilmiş a, b və c tərəflərinə görə üçbucaq qurmağın mümkünlüyünü və həmin
            //    üçbucağın bərabəryanlı, bərabərtərəfli və ya müxtəliftərəfli olmasını yoxlamalı

            Console.WriteLine("Ucbucaqin 3 terefi daxil edin. ");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            int z = Convert.ToInt32(Console.ReadLine());

            // var ya yox
            if(x + y > z && x + z > y && y + z > x)
            {
                // bərabərtərəfli
                if (x == y && y == z)
                {
                    Console.WriteLine("Bireberterefli");
                }
                // bərabəryanlı
                else if (x == y || y == z || x == z)
                {
                    Console.WriteLine("bireberyanli");
                }
                else
                {
                    Console.WriteLine("muxtelif");
                }
            }
            else
            {
                Console.WriteLine("Verilmis qurmaq mumkun deyil.");
            }

        }
    }
}
