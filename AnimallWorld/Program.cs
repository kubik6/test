namespace AnimallWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var animal = new Cat("Tom", 5, "Black", "Male");
            Console.WriteLine(animal.Name);
        }
    }
}
