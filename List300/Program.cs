namespace List300
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> num = new List<int>() { 1, 400, 200, 255, 300, 500, 1054, 2, 600 };
            bool result = Search(num);
            Console.WriteLine(result);

        }
        static bool Search(List<int> list)
        {
            // List<int> a = list.Find(x => x == 300);
            // return a > 0;

            foreach (int i in list)
            {
                if (i == 300) return true;

            }
            return false;
        }
    }
}
