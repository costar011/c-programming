// inch 단위를 입력 받아 cm 단위를 구하는 코드를 작성하시오.
Console.Write("inch 단위 입력: ");
double inch = double.Parse(Console.ReadLine());
Console.WriteLine(inch + "inch는 " + (inch * 2.54) + "cm입니다.");

// 사용자로부터 이름과 나이를 입력받아 5년 후의 나이를 출력하는 프로그램을 작성하시오.
Console.Write("이름을 입력하세요: ");
string name = Console.ReadLine();
Console.Write("나이를 입력하세요: ");
int age = int.Parse(Console.ReadLine());
Console.WriteLine($"{name}님의 5년 후 나이는 {age + 5}입니다.");

// 정수 두 개를 입력 받아 두 수의 합과 차를 출력하는 프로그램을 작성하시오.
Console.Write("첫 번째 정수를 입력하세요: ");
int num1 = int.Parse(Console.ReadLine());
Console.Write("두 번째 정수를 입력하세요: ");
int num2 = int.Parse(Console.ReadLine());
Console.WriteLine($"두 수의 합: {num1 + num2}");
Console.WriteLine($"두 수의 차: {num1 - num2}");

// 원의 반지름을 입력 받아 원의 둘레와 넓이를 구하는 코드를 작성하시오.
Console.Write("원의 반지름 입력: ");
double radius = double.Parse(Console.ReadLine());
Console.WriteLine("원의 둘레: " + (2 * 3.14 * radius));
Console.WriteLine("원의 넓이: " + (3.14 * radius * radius));

// 사용자에게 나이를 입력 받아, 나이에 따라 “성인” 또는 “미성년자”를 출력하는 프로그램을 if else 문을 이용하여 작성하시오.
Console.Write("나이를 입력하세요: ");
int age = int.Parse(Console.ReadLine());

if (age >= 18)
{
  Console.WriteLine("성인");
}
else
{
  Console.WriteLine("미성년자");
}


//주어진 정수가 3의 배수인 경우 “3의 배수입니다.”를 출력하고, 그렇지 않은 경우 “3의 배수가 아닙니다.”를 출력하는 코드를 작성하시오.
Console.Write("정수를 입력하세요: ");
int num = int.Parse(Console.ReadLine());

if (num % 3 == 0)
{
  Console.WriteLine("3의 배수입니다.");
}
else
{
  Console.WriteLine("3의 배수가 아닙니다.");
}

// 사용자에게 태어난 연도를 입력 받아 그 해의 띠를 출력하는 프로그램을 작성하시오.
Console.Write("태어난 연도: ");
int birth = int.Parse(Console.ReadLine());
switch (birth % 12)
{
  case 0:
    Console.WriteLine("원숭이 띠입니다.");
    break;
  case 1:
    Console.WriteLine("닭 띠입니다.");
    break;
  case 2:
    Console.WriteLine("개 띠입니다.");
    break;
  case 3:
    Console.WriteLine("돼지 띠입니다.");
    break;
  case 4:
    Console.WriteLine("쥐 띠입니다.");
    break;
  case 5:
    Console.WriteLine("소 띠입니다.");
    break;
  case 6:
    Console.WriteLine("호랑이 띠입니다.");
    break;
  case 7:
    Console.WriteLine("토끼 띠입니다.");
    break;
  case 8:
    Console.WriteLine("용 띠입니다.");
    break;
  case 9:
    Console.WriteLine("뱀 띠입니다.");
    break;
  case 10:
    Console.WriteLine("말 띠입니다.");
    break;
  case 11:
    Console.WriteLine("양 띠입니다.");
    break;
}

// 사용자에게 현재 월을 입력 받아 계절을 출력하는 프로그램을 작성하시오.
Console.Write("현재가 몇 월인지 입력해주세요: ");
int year = int.Parse(Console.ReadLine());
if (3 <= year && year <= 5)
{
  Console.WriteLine("봄입니다.");
}
else if (6 <= year && year <= 8)
{
  Console.WriteLine("여름입니다.");
}
else if (9 <= year && year <= 11)
{
  Console.WriteLine("가을입니다.");
}
else
{
  Console.WriteLine("겨울입니다.");
}

// 논리 연산자를 사용하여 다음 중첩 조건문을 if가 한 개인 조건문으로 작성하시오.
if (x > 10 && x < 20)
{
  Console.WriteLine("조건에 맞습니다.");
}

// 삼항 연산자를 활용하여 숫자 x가 짝수인지 홀수인지 출력하는 코드를 작성하시오.
int x = 5;
string result = (x % 2 == 0) ? "짝수" : "홀수";
Console.WriteLine(result);


// 다음 if 조건문으로 작성된 프로그램을 switch 조건문으로 변경하시오.
static void Main(string[] args)
{
  Console.Write("학년을 입력하세요: ");
  int level = int.Parse(Console.ReadLine());

  if (level == 1)
  {
    Console.WriteLine("수강해야 하는 전공 학점: 12학점");
  }
  else if (level == 2)
  {
    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
  }
  else if (level == 3)
  {
    Console.WriteLine("수강해야 하는 전공 학점: 10학점");
  }
  else if (level == 4)
  {
    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
  }
}

// 정답
Console.Write("학년을 입력하세요");
int level = int.Parse(Console.ReadLine());
switch (level)
{
  case 1:
    Console.WriteLine("수강해야 하는 전공 학점: 12학점");
    break;
  case 2:
    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
    break;
  case 3:
    Console.WriteLine("수강해야 하는 전공 학점: 10학점");
    break;
  case 4:
    Console.WriteLine("수강해야 하는 전공 학점: 18학점");
    break;
}

// 다음 코드의 for 반복문을 while 반복문으로 바꾸시오.
static void Main(string[] args)
{
  for (int i = 0; i < 10; i++)
  {
    Console.Write("출력");
  }
}

// 정답
int i = 0;
while (i < 10)
{
  Console.Write("출력");
  i++;
}

// 1부터 100까지의 숫자 중에서 짝수만 출력하는 for 반복문을 작성하시오.
for (int i = 2; i <= 100; i += 2)
{
  Console.WriteLine(i);
}

// 0부터 10까지의 숫자를 출력하는 while 반복문을 작성하시오.
int i = 0;
while (i <= 10)
{
  Console.WriteLine(i);
  i++;
}

// 1부터 10까지의 숫자 중 홀수만 출력하는 do-while 반복문을 작성하시오.
int i = 1;
do
{
  if (i % 2 != 0)
  {
    Console.WriteLine(i);
  }
  i++;
} while (i <= 10);

// 별 찍기
for (int i = 0; i < 8; i++)
{
  for (int j = 7; j >= i; j--)
  {
    Console.Write(" ");
  }
  for (int j = 0; j < 2 * i + 1; j++)
  {
    Console.Write("*");
  }
  Console.WriteLine();
}

// 수열의 20번째 숫자를 찾으시오.

string start = "1";

for (int i = 0; i < 20; i++)
{

  Console.WriteLine((i + 1) + "번째: " + start);


  string end = "";
  char number = start[0];
  int count = 0;
  for (int j = 0; j < start.Length; j++)
  {
    if (number != start[j])
    {
      end = end + number + count;
      number = start[j];
      count = 1;
    }
    else
    {
      count++;
    }
  }
  end = end + number + count;


  start = end;
}

// static 키워드를 이용하여, Math 클래스처럼 유용한 상수나 메서드를 정의한 클래스를 작성하시오.
class MathUtils
{
  public static double Pi = 3.14159;

  public static double Square(double value)
  {
    return value * value;
  }
}

Console.WriteLine($"Pi 값: {MathUtils.Pi}");
Console.WriteLine($"4의 제곱: {MathUtils.Square(4)}");

// 다음과 같은 변수를 가지는 클래스를 만들고, 값을 넣어 인스턴스를 생성하시오. 클래스의 이름을 Book으로 만들고, 변수의 이름과 자료형은 알맞다고 생각하는 방식으로 선언하시오.
// img 파일

class Book
{
  public string name;
  public DateTime publishedDate;
  public string author;
  public string owner;
  public string publisher;
  public string seniorEditor;
  public string producer;
  public string editor;
  public string designer;
}

Book book = new Book()
{
  name = "로키 리눅스",
  publishedDate = new DateTime(2024, 7, 1),
  author = "이종원",
  owner = "전태호",
  publisher = "한빛아카데미(주)",
  seniorEditor = "김성무",
  producer = "정지윤",
  editor = "정지윤",
  designer = "박정우"
};

// 다음과 같은 변수를 가지는 클래스를 만들고, 값을 넣어 인스턴스를 생성하시오. 클래스의 이름을 Unit으로 만들고, 변수의 이름과 자료형은 알맞다고 생각하는 방식으로 선언하시오.

class Unit
{
  public string Name;
  public int Mineral;
  public int Supply;
  public int Hp;
  public int Attack;
}

Unit scv = new Unit()
{
  Name = "건설 로봇",
  Mineral = 50,
  Supply = 1,
  Hp = 45,
  Attack = 5
};


// 다음과 같은 변수를 가지는 클래스를 만들고, 값을 넣어 인스턴스를 생성하시오.
// 변수의 이름과 자료형은 알맞다고 생각하는 방식으로 선언하시오. Person과 Pet이라는 클래스를 2개 만들고, 두 클래스가 연관 관계를 갖도록 하며, Pet 클래스의 인스턴스는 다음과 같이 2개로 만드시오.
// Person 클래스의 인스턴스는 다음과 같이 1개로 만드시오.

class Pet
{
  public string name;
  public int age;
}

class Person
{
  public string name;
  public string address;
  public List<Pet> pets;
}

static void Main(string[] args)
{
  Pet cloud = new Pet() { name = "구름", age = 7 };
  Pet star = new Pet() { name = "별", age = 1 };

  Person person = new Person()
  {
    name = "윤인성",
    address = "서울특별시 강서구",
    pets = new List<Pet>() { cloud, star }
  };
}

// 다음 코드의 실행 결과를 예측하시오.
class MyMath
{
  static int Abs(int input)
  {
    return input > 0 ? input : -input;
  }

  static double Abs(int input)
  {
    return input > 0 ? input : -input;
  }

  static long Abs(long input)
  {
    return input > 0 ? input : -input;
  }

  static double Abs(long input)
  {
    return input > 0 ? input : -input;
  }
}

// 정답 : 메서드 오버로딩 오류가 발생

// 다음 코드에서 예외가 발생하는 부분을 고르시오.s
class Unit { }
class Tank : Unit { }

class Program
{
  static void Main(string[] args)
  {
    Unit unit = new Unit();
    Tank tank = new Tank();
    /* 1 */
    Unit a = (Unit)unit;
    /* 2 */
    Unit b = (Unit)tank;
    /* 3 */
    Tank c = (Tank)unit;
    /* 4 */
    Tank d = (Tank)tank;
  }
}
// 답: 3번


// 다음 코드는 10을 출력하는가? 20을 출력하는가?

class Parent
{
  public int question = 10;
}

class Child : Parent
{
  public string question = "20";
}

// 답: 20

// 위의 06번 문제에서 둘 중 출력되지 않은 값을 출력하게 하려면 코드를 어떻게 수정해야 하는가?
Child child = new Child();
Console.WriteLine(((Parent)child).question);

// 또는
Parent child = new Child();
Console.WriteLine(child.question);