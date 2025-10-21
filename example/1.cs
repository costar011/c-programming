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