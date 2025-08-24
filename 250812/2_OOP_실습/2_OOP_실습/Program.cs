using System.Xml.Linq;

namespace _2_OOP_실습
{
    class Animal
    {
        public string name;

        public Animal(string name)
        {
            Console.WriteLine($"안녕하세요 저는 {name} 입니다");
        }
        public virtual void MakeSound()
        {
            Console.WriteLine("기본값");
        }
    }

    class Dog : Animal
    {
        public Dog(string name) : base(name)
        {
            
        }

        public override void MakeSound()
        {
            Console.WriteLine("멍멍");
        }
    }
    class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("냐옹");
        }
    }
    class Cow : Animal
    {
        public Cow(string name) : base(name)
        {
            
        }
        public override void MakeSound()
        {
            Console.WriteLine("음메");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog("강아지");
            dog.MakeSound();
            Cat cat = new Cat("고양이");
            cat.MakeSound();
            Cow cow = new Cow("소");
            cow.MakeSound();
        }
    }
}
