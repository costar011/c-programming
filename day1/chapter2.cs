namespace Chapter2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 기본 문법
            // 2-1
            Console.Write("Hello C# Programming .. !");

            /*
            연산자  설명 
            +   더하기
            -   빼기
            *   곱하기
            /   나누기
            %   나머지
             */

            // 2-2
            Console.WriteLine(52);
            Console.WriteLine("==========================================");

            // 2-3
            Console.WriteLine(52 + 273);
            Console.WriteLine("==========================================");

            // 2-4
            // 결과 예측
            Console.WriteLine(5 + 3 * 2);
            Console.WriteLine("==========================================");

            // 2-5
            Console.WriteLine(10 % 5);
            Console.WriteLine(7 % 3);
            Console.WriteLine("==========================================");

            // 2-6
            Console.WriteLine(1 + 2);
            Console.WriteLine(1 - 2);
            Console.WriteLine(1 * 2);
            Console.WriteLine(1 / 2);
            Console.WriteLine(1 % 2);
            Console.WriteLine("==========================================");

            // 2-7 ( 왼쪽 피연산자의 부호 따름 )
            Console.WriteLine(4 % 3);
            Console.WriteLine(-4 % 3);
            Console.WriteLine(4 % -3);
            Console.WriteLine(-4 % -3);
            Console.WriteLine("==========================================");

            // 2-8 ( 실수 )
            Console.WriteLine(52.273);
            Console.WriteLine("==========================================");

            // 2-9 ( 정수와 실수 )
            Console.WriteLine(0); // 정수 
            Console.WriteLine(0.0); // 실수
            Console.WriteLine("==========================================");

            // 2-10 (실수와 사칙연산 )
            Console.WriteLine(1.0 + 2.0);
            Console.WriteLine(1.0 - 2.0);
            Console.WriteLine(1.0 * 2.0);
            Console.WriteLine(1.0 / 2.0);
            Console.WriteLine("==========================================");

            // 2-11
            Console.WriteLine(5.0 % 2.2); // 결과 : 0.5999999999999996 
            Console.WriteLine(Math.Round(5.0 % 2.2, 2)); // 결과 : 0.6
            Console.WriteLine("==========================================");

            // 2-12
            Console.WriteLine("A");
            Console.WriteLine("가");
            Console.WriteLine("나");
            Console.WriteLine("==========================================");

            // 2-13
            Console.WriteLine("안녕하세요");
            Console.WriteLine("==========================================");

            // 2-14
            Console.WriteLine("한빛\t아카데미");
            Console.WriteLine("한빛\n아카데미");
            Console.WriteLine("\"\"\"");
            Console.WriteLine("==========================================");

            // 2-15
            Console.WriteLine("가나다" + "라마" + "바사아" + "자차카타" + "파하");
            Console.WriteLine("==========================================");

            // 2-16
            Console.WriteLine("안녕하세요"[0]);
            Console.WriteLine("안녕하세요"[1]);
            Console.WriteLine("안녕하세요"[3]);
            Console.WriteLine("==========================================");

            // 2-17
            // Console.WriteLine("안녕하세요"[100]);

            // 2-18
            Console.WriteLine('가' + '힣');
            Console.WriteLine("==========================================");

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
            Console.WriteLine(! (52 > 273));
            Console.WriteLine("==========================================");
        }
    }
}
