namespace Registration
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adinizi daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadinizi Daxil edin");
            string surname = Console.ReadLine();

            Console.WriteLine("Yasinizi daxil edin");
            int age = Convert.ToInt32(Console.ReadLine());

            User user = new User(name, surname, age);

            user.DisplayUser();
            
        }
    }
}
