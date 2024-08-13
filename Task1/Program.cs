using System.Security.Cryptography;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Task 1

            /* 
             Bərabəryanlı düzbucaqlının eni və uzunluğunu istifadəçidən alın. Perimetri və sahəsini hesablayın
                 Example
                    5
                      6
                         22
                          30
             */

            //Console.WriteLine("Write width");
            //int width = Convert.ToInt32(Console.ReadLine());

            //Console.WriteLine("Write length");
            //int lentgth = Convert.ToInt32(Console.ReadLine());

            //int per = 2 * (width + lentgth);
            //int area = width * lentgth;

            //Console.WriteLine($"Perimetr is {per}");
            //Console.WriteLine($"Area is {area}");


            //Task2 --------------------------------------------------------------------------------------------------------
            //İstifadəçidən 2 int dəyər alın və birinci ədədi ikinciyə bölün . Misal: 16, 5.Nəticə 3 yox, 3,2 olmalıdır.

            //Console.WriteLine("Write two numbers");
            //int a = Convert.ToInt32(Console.ReadLine());
            //int b = Convert.ToInt32(Console.ReadLine());

            //double c = (double) a / b;

            //Console.WriteLine($"Answer {c}");

            // Task 3 ---------------------------------------------------------------------------------------------------------
            //Task3
            // Tip Çevirmelerine aid 5 nümunə yazın

            // 1 ============
            //double val = 156.89;
            //int valInt = (int)val;
            //Console.WriteLine(valInt); // 156

            // 2 ===================
            //string text = "123";
            //int num = Convert.ToInt32(text);
            //Console.WriteLine(num);

            //3 ======================
            //string text = "0123";
            //int num = int.Parse(text);
            //Console.WriteLine(num);

            //4 ========================
            //int num = 0568;
            //string text = Convert.ToString(num);
            //Console.WriteLine(text);

            //5 ==========================
            //string text = "456";
            //bool result = int.TryParse(text, out int textInInt);
            //if (result)
            //{
            //    Console.WriteLine(text);
            //}
            //else
            //{
            //    Console.WriteLine("Cannot convert");
            //}

            //Task 4 ------------------------------------------------------------------------------------------------------------
            // Ədədlər üzərində operatorlardan istifadə etməklə nümunələr yazın.
            //  Hər operotara aid 1 nümunə.Fərqli data typle - lardan istifadə edin


            //int a = 5;
            //int b = 10;
            //int sum = a + b;
            //Console.WriteLine($"Sum {a} + {b} = {sum}");

            //double x = 10.5;
            //double y = 3.2;
            //double difference = x - y;
            //Console.WriteLine($"Minus {x} - {y} = {difference}");

            //float m = 2.5f;
            //float n = 4.0f;
            //float product = m * n;
            //Console.WriteLine($"Product {m} * {n} = {product}");

            //decimal p = 20.0m;
            //decimal q = 6.0m;
            //decimal division = p / q;
            //Console.WriteLine($"Division {p} / {q} = {division}");

            //int num1 = 17;
            //int num2 = 5;
            //int remainder = num1 % num2;
            //Console.WriteLine($"Modulus {num1} % {num2} = {remainder}");

            //Task5-------------------------------------------------------------------------------------------------------------------------
            //int number1 = 7;
            //int number2 = 8;
            //int number3 = 9;
            //var result = !(number1 <= number2) == (number3 != number3++);
            //bunu consola yazdrsaq cavab nece olar?

            // true



        }
    }
}
