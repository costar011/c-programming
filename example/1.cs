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