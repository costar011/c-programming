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

print("####################");

using System;

class Program
{
    class Parent
    {
        public int variable = 273;
    }

    class Child : Parent
    {
        public string variable = "shadowing";
    }

    static void Main(string[] args)
    {
        Child child = new Child();
        Console.WriteLine(child.variable);
    }
}

print("####################");

using System;
using System.Windows.Forms;

public partial class Form1 : Form
{
    class CustomForm : Form
    {
        // Form 클래스를 상속
    }

    public Form1()
    {
        InitializeComponent();
    }

    private void button1_Click(object sender, EventArgs e)
    {
        CustomForm form = new CustomForm();
        form.Show(); // Form 클래스를 상속받으므로 Show() 메서드를 사용할 수 있음
    }
}

print("####################");

class Program
{
    static void NextPosition(int x, int y, int vx, int vy, out int rx, out int ry)
    {
        // 다음 위치 = 현재 위치 + 현재 속도
        rx = x + vx;
        ry = y + vy;
    }

    static void Main(string[] args)
    {
        int x = 0;
        int y = 0;

        int vx = 1;
        int vy = 1;

        // 현재 좌표 출력
        Console.WriteLine("현재 좌표: (" + x + "," + y + ")");
        NextPosition(x, y, vx, vy, out x, out y);

        // 다음 좌표 출력
        Console.WriteLine("다음 좌표: (" + x + "," + y + ")");
    }
}

print("####################");