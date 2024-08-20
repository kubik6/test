namespace FullNameProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Adi daxil edin");
            string name = Console.ReadLine();

            Console.WriteLine("Soyadinizi daxil edin");
            string surname = Console.ReadLine();

            Person person = new Person(name, surname);

            person.Display();
        }
    }
}
