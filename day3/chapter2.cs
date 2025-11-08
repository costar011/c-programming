using System;
using System.Collections.Generic;

class Animal
{
    public void Eat()
    {
        Console.WriteLine("Eating...");
    }

    public void Sleep()
    {
        Console.WriteLine("Sleeping...");
    }
}

class Dog : Animal
{
    public void Bark()
    {
        Console.WriteLine("Barking!");
    }
}

class Cat : Animal
{
    public void Meow()
    {
        Console.WriteLine("Meowing!");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<Animal> Animals = new List<Animal>()
        {
            new Dog(), new Dog(), new Cat(), new Cat()
        };

        foreach (var item in Animals)
        {
            item.Eat();
            item.Sleep();

            if (item is Dog)
            {
                Console.WriteLine("This is a Dog.");
            }

            if (item is Cat)
            {
                Console.WriteLine("This is a Cat.");
            }
        }
    }
}


print("####################");


print("int.TryParse()");
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("숫자 입력: ");
        int output;

        bool result = int.TryParse(Console.ReadLine(), out output);

        if (result)
        {
            Console.WriteLine("입력한 숫자: " + output);
        }
        else
        {
            Console.WriteLine("숫자를 입력해주세요!");
        }
    }
}
