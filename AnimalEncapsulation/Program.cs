namespace AnimalEncapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
           Dog dog = new Dog() {Name = "Zevs", Age = 5, HasOwner = true };
            dog.Eat();
            dog.Sleep();

            Cat cat = new Cat() { Name = "Tom", Age = 6, HasOwner = true};
            cat.Eat();
            cat.Sleep();
        }
    }
}
