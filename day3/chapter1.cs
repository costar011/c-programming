class Dog
{
 public int Age { get; set; }
 public string Color { get; set; }

 public Dog() { this.Age = 0; }

 public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
 public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
 public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
}

//////////////////////////////

class Cat
{
 public int Age { get; set; }

 public Cat() { this.Age = 0; }

 public void Eat() { Console.WriteLine("냠냠 먹습니다."); }
 public void Sleep() { Console.WriteLine("쿨쿨 잠을 잡니다."); }
 public void Meow() { Console.WriteLine("냥냥 웁니다."); }
}

//////////////////////////////

class Dog : Animal   // Animal 클래스의 상속을 받습니다.
{
 public string Color { get; set; }

 public void Bark() { Console.WriteLine("왈왈 짖습니다."); }
}

class Cat : Animal   // Animal 클래스의 상속을 받습니다.
{
 public void Meow() { Console.WriteLine("냥냥 웁니다."); }
}
