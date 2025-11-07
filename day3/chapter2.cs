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
