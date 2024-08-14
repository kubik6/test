using System;
using System.Reflection.Metadata;

namespace Task7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1 ================================================================================================
            // Istifadeciden 1 eded alin ve bir array yaradin. Hemin ededin arrayin icinde olub olmadigini yoxlayin

            //int[] ints = { 5, 10, 155, 7777, 6669, 15, 4 };
            //bool found = false;

            //while (!found)
            //{

            //    Console.WriteLine("eded tapin");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    foreach (int i in ints)
            //    {
            //        if (i == num)
            //        {
            //            Console.WriteLine("Taptiz " + i + " bele reqem var");
            //            found = true;
            //        }
            //    }

            //    if (!found) Console.WriteLine("Behtinizi birde sinayin");


            // Task 2 ====================================================================================================
            // Istifadeciden bir array alin. Hemin array de tekrarlanan elementleri capa verin.
            // + hansi indexlerde tekrarlanibsa onlarida capa verin

            //Console.WriteLine("array uzunlugu verin");
            //int length = Convert.ToInt32(Console.ReadLine());

            //int[] ints = new int[length];

            //Console.WriteLine("Ededleri daxil edin");
            //for (int i = 0; i < length; i++)
            //{
            //    ints[i] = Convert.ToInt32(Console.ReadLine());
            //}

            //bool[] check = new bool[length];

            //for (int i = 0; i < ints.Length; i++)
            //{
            //    if (check[i]) continue;

            //    for (int j = i + 1; j < ints.Length; j++)
            //    {
            //        if (ints[i] == ints[j])
            //        {
            //            Console.WriteLine($"Dublicat eded {ints[i]} index {j}");
            //            check[j] = true;
            //            // check[i] = true;
            //        }

            //    }

            //}

            // Task 3 ==========================================================================================================
            // Bir eded daxil edin ve hemin ededin sade olub olmadigini yoxlayin

            //Console.WriteLine("eded daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num <= 1 || num == 0)
            //{
            //    Console.WriteLine("sade deyil ");
            //    return;
            //}

            //bool prime = true;

            //for (int i = 2; i < num; i++)
            //{
            //    if (num % i == 0)
            //    {
            //        prime = false;
            //        Console.WriteLine(num + " sade deyil");
            //        break;

            //    }
            //}

            //if (prime) Console.WriteLine(num + " sade reqemdi");

            // Task 4 =============================================================================================================
            // While ilə dövr yaradın. Hər dövrdə istifadəçidən 2 ədəd istəyin.
            // Əgər bu 2 ədədin cəmi 6 - ya qalıqsız bölünürsə bu zaman dövrü sonlandırın.Əks halda dövrü təkrarlayın.

            //while (true)
            //{
            //    Console.WriteLine("2 eded daxil edin");
            //    int a = Convert.ToInt32(Console.ReadLine());
            //    int b = Convert.ToInt32(Console.ReadLine());    

            //    if ((a + b) % 6 == 0)
            //    {
            //        Console.WriteLine("Done!!");
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Cemi 6 bolunmur");
            //    }
            //}

            // Task 5 =============================================================================================================
            // Verilmiş ədədin faktorialını hesablayın

            //Console.WriteLine("Eded daxil edin faktorial hesabla");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num < 1)
            //{
            //    Console.WriteLine("Eded positive olmalidi");
            //}
            //else
            //{
            //    int factorial = 1;

            //    for (int i = 1; i <= num; i++)
            //    {
            //        factorial *= i;
            //    }

            //    Console.WriteLine(factorial);
            //}


            // Task 6 ==============================================================================================================
            // İstifadəçidən bir ədəd alın. O ədəd qədər fibonnaci sırası yaradın.

            //Console.WriteLine("Eded yazin fibonaci sirasi yaradmaq");
            //int num = Convert.ToInt32(Console.ReadLine());

            //int a = 0;
            //int b = 1;


            //Console.Write("0 1 ");

            //while (true)
            //{

            //    int c = a + b;

            //    if (c > num)
            //    {
            //        break;
            //    }
            //    else
            //    {
            //        Console.Write($"{c} ");
            //        a = b;
            //        b = c;
            //    }
            //}

            // ==================================================================================================================
            // polindrom

            //Console.WriteLine("Polindrom yoxlamasi");
            //string input = Console.ReadLine();

            //bool polindrom = true;
            //int start = 0;
            //int end = input.Length - 1;

            //while (start < end)
            //{


            //    if (input[start] != input[end])
            //    {
            //        Console.WriteLine(input + "Polindrom deyil");
            //        polindrom = false;
            //        break;
            //    }

            //    start++;
            //    end--;

            //}


            //if (polindrom) Console.WriteLine(input + " polindromdu");


            // =====================================================================================================================================
            //  Bir hesablama methodu yazın. Bu methoda int tipində dəyərlər əlavə edin və bu dəyərləri daxildə toplayın.
            //  bunun üçün method overloadingdən istifadə edin.bir methodunuzda 2 parametr, birində 3 və s.



            //Console.WriteLine(Sum(5, 6));
            //Console.WriteLine(Sum(7, 8));
            //Console.WriteLine(Sum(5, 6, 8));
            //Console.WriteLine(Sum(5, 6, 8, 9));

        }

        //public static int Sum(int a, int b)
        //{
        //    return a + b;
        //}

        //public static long Sum(long a, long b)
        //{

        //    return a + b;
        //}

        //public static int Sum(int a, int b, int c)
        //{
        //    return a + b + c;
        //}

        //public static int Sum(int a, int b, int c, int d)
        //{
        //    return a + b + c + d;
        //}

    }

}
