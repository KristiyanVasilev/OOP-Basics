namespace SingleInheritance
{
    public class SingleInheritance
    {
        public static void Main()
        {
            var dog = new Dog();
            dog.Eat();
            dog.Bark();
            var cat = new Cat();
            cat.Eat();
            cat.Meow();
        }
    }
}
