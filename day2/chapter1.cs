namespace Chapter1
{
 internal class Program
 {
  static void Main(string[] args)
  {
   /*
   불 자료형 (Boolean Type)
   bool은 true와 false 두 가지 값만을 가질 수 있는 자료형
   */
   // 2-19
   Console.WriteLine(true); // 참
   Console.WriteLine(false); // 거짓
   Console.WriteLine("==========================================");

   // 2-20
   Console.WriteLine(52 < 273);
   Console.WriteLine(52 > 273);
   Console.WriteLine("==========================================");

   // 2-21
   Console.WriteLine(!true);
   Console.WriteLine(!false);
   Console.WriteLine(!(52 < 273));
   Console.WriteLine(!(52 > 273));
   Console.WriteLine("==========================================");

   // 2-22
   Console.WriteLine(DateTime.Now.Hour < 3 || 8 < DateTime.Now.Hour);
   Console.WriteLine(3 < DateTime.Now.Hour || DateTime.Now.Hour < 8);
   Console.WriteLine("==========================================");

   /*
    * 변수 - 값을 저장할 때 사용하는 식별자
    * 변수 만드는 것 -> 변수 선언 표현
    * 변수에 값 넣는 것 -> 변수에 값 할당
    * 
    * int - 4byte
    * long - 8byte
    */

   // 2-23
   int a = 273;
   int b = 52;

   Console.WriteLine(a + b);
   Console.WriteLine(a - b);
   Console.WriteLine(a * b);
   Console.WriteLine(a / b);
   Console.WriteLine(a % b);
   Console.WriteLine("==========================================");

   // 2-24
   int c = 2147483640;
   int d = 52273;
   Console.WriteLine(c + d); // 오버플로우 발생
   Console.WriteLine("==========================================");

   /*
    * 오버플로우(overflow) - 표현할 수 있는 값의 범위를 벗어나는 상황
    */
   // 2-25
   int e = 200000000;
   int f = 100000000;
   Console.WriteLine(e + f); // 오버플로우 발생
   Console.WriteLine("==========================================");

   /*
    * unsigned - 음수를 표현하지 않는 자료형
    */
   // 2-26
   uint unsignedA = 2000000000;
   uint unsignedB = 1000000000;
   Console.WriteLine(unsignedA + unsignedB); // 오버플로우 발생하지 않음
   Console.WriteLine("==========================================");

   // 2-27
   uint unsigendInt = 4147483647;
   ulong unsignedLong = 11223372036854775800;

   Console.WriteLine(unsigendInt);
   Console.WriteLine(unsignedLong);
   Console.WriteLine("==========================================");

   /*
    * MaxValue, MinValue - 자료형이 표현할 수 있는 최대값과 최소값
    */

   // 2-28
   Console.WriteLine(int.MaxValue);
   Console.WriteLine(int.MinValue);
   Console.WriteLine("==========================================");

   // 2-29
   Console.WriteLine(long.MaxValue);
   Console.WriteLine(long.MinValue);
   Console.WriteLine("==========================================");

   /*
    * 실수 자료형 (Floating-point Type) - 소수점이 있는 숫자를 표현하는 자료형
    * 
    * float - 4byte
    * double - 8byte
    */

   // 2-30
   double g = 52.273;
   double h = 103.32;

   Console.WriteLine(g + h);
   Console.WriteLine(g - h);
   Console.WriteLine(g * h);
   Console.WriteLine(g / h);
   Console.WriteLine("==========================================");

   /*
    * 문자 자료형 (Character Type) - 단일 문자를 표현하는 자료형
    * char - 문자
    */
   // 2-31
   char i = 'A';
   Console.WriteLine(i);
   Console.WriteLine("==========================================");

   /*
    * sizeof 연산자 - 자료형의 크기를 바이트 단위로 반환
    */
   // 2-32
   Console.WriteLine("int: " + sizeof(int));
   Console.WriteLine("long: " + sizeof(long));
   Console.WriteLine("float: " + sizeof(float));
   Console.WriteLine("double: " + sizeof(double));
   Console.WriteLine("char: " + sizeof(char));
   Console.WriteLine("==========================================");

   // 2-33
   char a = 'A';
   char b = 'B';

   Console.WriteLine(a + b);
   Console.WriteLine(a - b);
   Console.WriteLine(a * b);
   Console.WriteLine(a / b);
   Console.WriteLine(a % b);
   Console.WriteLine("==========================================");

   // 2-34
   string message = "안녕하세요";

   Console.WriteLine(message + "!");
   Console.WriteLine(message + [0]);
   Console.WriteLine(message + [1]);
   Console.WriteLine(message + [2]);
   Console.WriteLine("==========================================");

   // 2-35
   /*
   String 자료형은  sizeof 연산자로 크기를 구할 수 없음
   문자열은 다른 기본 자료형과 다르기 떄문
   */
   Console.WriteLine("String: " + sizeof(string));

   Console.WriteLine("==========================================");

   // 2-36
   bool one = 10 < 0;
   bool other = 20 > 100;

   Console.WriteLine(one);
   Console.WriteLine(other);

   Console.WriteLine("==========================================");

   // 2-37
   int output = 0;
   output += 52;
   output += 273;
   output += 103;
   Console.WriteLine(output);

   Console.WriteLine("==========================================");

   // 2-38
   int output2 = 0;
   output2 + 52;
   output2 + 273;
   output2 + 103;
   Console.WriteLine(output2);

   Console.WriteLine("==========================================");

   // 2-39
   // 복합 대입 연산자
   string output3 = "Hello";
   output3 += "World";
   output3 += "!";
   Console.WriteLine(output3);

   Console.WriteLine("==========================================");

   // 2-40
   string output4 = "Hello";
   output4 += "World";
   output4 += "!";
   Console.WriteLine(output4);

   Console.WriteLine("==========================================");

   // 2-41
   intnumber = 10;
   number++;
   Console.WriteLine(number);
   number--;
   Console.WriteLine(number);

   Console.WriteLine("==========================================");

   // 2-42
   int number2 = 10;
   Console.WriteLine(number2);
   Console.WriteLine(number2++);
   Console.WriteLine(number2--);
   Console.WriteLine(number2);

   Console.WriteLine("==========================================");

   // 2-43
   int number3 = 10;
   Console.WriteLine(number3);
   Console.WriteLine(number3); number3 += 1;
   Console.WriteLine(number3); number3 -= 1;
   Console.WriteLine(number3);

   Console.WriteLine("==========================================");

  }
 }
}
