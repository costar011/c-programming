// 다음 코드의 실행 결과를 예측 하시오
int[] numbers = { 1, 2, 3 };
for (int i = 0; i < numbers.Length; i++)
{
 Console.WriteLine(numbers[i]);
}

// 답 : 1, 2, 3

using System;

namespace chapter2
{
 class Program
 {
  static void Main(string[] args)
  {
   //HINT 1inch = 2.54cm 

   Console.WriteLine("inch 단위를 입력하세요 : ");
   double inch = double.Parse(Console.ReadLine());
   Console.WriteLine(inch + "inch는 " + (inch * 2.54) + "cm입니다.");
  }
 }
}
