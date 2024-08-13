using System.Threading.Tasks;
using System;

namespace Task6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Task1
            //1 - dən 1000 - ə qədər olan ədədlərin içində 3 - ə və 5 - ə bölünən ədədləri konsola yazdırın.

            //for (int i = 1; i <= 1000; i++)
            //{
            //    if (i % 3 == 0 && i % 5 == 0)
            //    {
            //        Console.WriteLine(i);
            //    }
            //}

            //Task 2 ===========================================================================================================================
            //İstifadəçidən bir ədəd daxil etməsini istəyin və o ədəd qədər ekrana random ədədlər çap edin.

            //Console.WriteLine("Nomre daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());

            //Random random = new Random();

            //for (int i = 0; i < num; i++) 
            //{ 
            //    int randomNum = random.Next(0, num);
            //    Console.WriteLine(randomNum);
            //}

            //Task 3=============================================================================================================================

            //Istifadəçidən 10 ilə 20 arasında bir rəqəm alın . Bir array yaradın və daxil edilən rəqəm sayı qədər arraya
            // random rəqəm daxil edin.Daha sonra həmin arrayin içərisindən tək ədədləri ayrı, cüt ədələri ayrı şəkildə,
            // ardıcıllıqla konsola yazdırın.

            //    Console.WriteLine("10 - 20 arasi reqem yazin ");
            //    int num = Convert.ToInt32(Console.ReadLine());

            //    if (num < 10 || num > 20)
            //    {
            //        Console.WriteLine("10 - 20 deyil");
            //        return;
            //    }

            //    int[] arrNum = new int[num];

            //    Random random = new Random();

            //    var arrAll = "";
            //    var even = "";
            //    var odd = "";

            //    for (int i = 0; i < num; i++)
            //    {
            //        arrNum[i] = random.Next(1, 100);
            //        arrAll += arrNum[i] + " ";

            //        if (arrNum[i] % 2 == 0)
            //        {
            //            even += arrNum[i] + " ";
            //        }
            //        else
            //        {
            //            odd += arrNum[i] + " ";
            //        }

            //    }

            //    Console.WriteLine("Butun arr: " + arrAll); 
            //    Console.WriteLine("Cut eded: " + even);
            //    Console.WriteLine("Tek ede: " + odd);

            //Task 4 ====================================================================================================================
            // 3 rəqəmli ədədin rəqəmləri cəmini tapın

            //Console.WriteLine("3 regemli eded daxil edin");
            //int num = Convert.ToInt32(Console.ReadLine());

            //if (num < 100 || num > 999)
            //{
            //    Console.WriteLine("3 regemli deyil");
            //    return;
            //}

            //string numString = Convert.ToString(num);

            //int sum = 0;

            //for (int i = 0; i < numString.Length; i++)
            //{
            //    //sum += Convert.ToInt32(numString[i]);
            //  sum += numString[i] - '0';


            //}

            //Console.WriteLine("Ededlerin cemi: " + sum);

            // Task 5 ========================================================================================================================
            // Verilmiş 3 ədəddən ən böyük və ən kiçiyini tapın

            //Console.WriteLine("3 eded daxil edin");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());
            //int c = Convert.ToInt32(Console.ReadLine());

            //int max = a;
            //int min = a;

            //if (b > max) max = b;
            //if (c > max) max = c; 

            //if (b < min) min = b;
            //if (c < min) min = c;

            //Console.WriteLine("Max: " + max);
            //Console.WriteLine("Min: " + min);




           // Version 2 -----------------------------------------------------------

            //int[] num = {a, b, c};


            //Console.WriteLine("Boyuk: " + num.Max());
            //Console.WriteLine("Kicik:" + num.Min());

            //Task 6 ========================================================================================================================
            // 3 rəqəmli ədədlərdən 7 və 8-ə bölünən ədədlərin cəmini tapın

            //int sum = 0;

            //for (int i = 100; i <= 999; i++)
            //{
            //    if (i % 8 == 0 && i % 7 == 0 )
            //    {
            //        sum += i;
            //    }
            //}

            //Console.WriteLine("Cemi: " + sum);

        }
    }
}
