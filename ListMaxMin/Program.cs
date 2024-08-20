namespace ListMaxMin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 5, 60, 55, 0, 26, 88, 100, 99, 81};

            int max = 0;
            int min = 0;

            foreach (int i in num)
            {
                if (i > max) max = i;
                if (i < min) min = i;
            }

            Console.WriteLine("Max " + max);
            Console.WriteLine("Min " + min);
        }
    }
}
