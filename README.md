# # C# programming University subject classes

## 목차

1. [C#이란?](#c이란)
2. [기본 문법](#기본-문법)
3. [데이터 타입](#데이터-타입)
4. [변수와 상수](#변수와-상수)
5. [연산자](#연산자)
6. [제어문](#제어문)
7. [배열과 컬렉션](#배열과-컬렉션)
8. [클래스와 객체](#클래스와-객체)
9. [메서드](#메서드)
10. [상속과 다형성](#상속과-다형성)
11. [예외 처리](#예외-처리)
12. [네임스페이스](#네임스페이스)

## C#이란?

C#(C Sharp)은 Microsoft에서 개발한 객체지향 프로그래밍 언어임 .NET Framework와 .NET Core/.NET 5+ 플랫폼에서 실행되며, Windows, Linux, macOS 등 다양한 운영체제에서 사용 가능

### 주요 특징

- **객체지향**: 클래스, 상속, 캡슐화, 다형성 지원
- **타입 안전성**: 컴파일 타임에 타입 검사
- **메모리 관리**: 가비지 컬렉션으로 자동 메모리 관리
- **플랫폼 독립성**: .NET 런타임이 설치된 모든 플랫폼에서 실행

## 기본 문법

### Hello World 프로그램

```csharp
using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
    }
}
```

### 기본 구조

- `using System;`: 네임스페이스 import
- `class Program`: 클래스 정의
- `static void Main()`: 프로그램 진입점
- `Console.WriteLine()`: 콘솔 출력

## 데이터 타입

### 기본 데이터 타입 (Value Types)

| 타입      | 크기     | 범위                                                   | 설명                  |
| --------- | -------- | ------------------------------------------------------ | --------------------- |
| `bool`    | 1 byte   | true/false                                             | 불린값                |
| `byte`    | 1 byte   | 0 ~ 255                                                | 부호 없는 8비트 정수  |
| `sbyte`   | 1 byte   | -128 ~ 127                                             | 부호 있는 8비트 정수  |
| `short`   | 2 bytes  | -32,768 ~ 32,767                                       | 부호 있는 16비트 정수 |
| `ushort`  | 2 bytes  | 0 ~ 65,535                                             | 부호 없는 16비트 정수 |
| `int`     | 4 bytes  | -2,147,483,648 ~ 2,147,483,647                         | 부호 있는 32비트 정수 |
| `uint`    | 4 bytes  | 0 ~ 4,294,967,295                                      | 부호 없는 32비트 정수 |
| `long`    | 8 bytes  | -9,223,372,036,854,775,808 ~ 9,223,372,036,854,775,807 | 부호 있는 64비트 정수 |
| `ulong`   | 8 bytes  | 0 ~ 18,446,744,073,709,551,615                         | 부호 없는 64비트 정수 |
| `float`   | 4 bytes  | ±1.5 × 10⁻⁴⁵ ~ ±3.4 × 10³⁸                             | 32비트 부동소수점     |
| `double`  | 8 bytes  | ±5.0 × 10⁻³²⁴ ~ ±1.7 × 10³⁰⁸                           | 64비트 부동소수점     |
| `decimal` | 16 bytes | ±1.0 × 10⁻²⁸ ~ ±7.9228 × 10²⁸                          | 128비트 정밀한 소수   |
| `char`    | 2 bytes  | U+0000 ~ U+FFFF                                        | 유니코드 문자         |
| `string`  | 가변     | 문자열                                                 | 참조 타입             |

### 참조 타입 (Reference Types)

- `object`: 모든 타입의 기본 클래스
- `string`: 문자열
- `dynamic`: 런타임에 타입 결정
- 사용자 정의 클래스

## 변수와 상수

### 변수 선언

```csharp
// 기본 선언
int age = 25;
string name = "홍길동";
bool isStudent = true;

// 여러 변수 동시 선언
int x = 10, y = 20, z = 30;

// var 키워드 (타입 추론)
var count = 100;        // int로 추론
var message = "Hello";  // string으로 추론
```

### 상수

```csharp
// const: 컴파일 타임 상수
const double PI = 3.14159;
const string COMPANY_NAME = "MyCompany";

// readonly: 런타임 상수
readonly DateTime createdDate = DateTime.Now;
```

## 연산자

### 산술 연산자

```csharp
int a = 10, b = 3;

int sum = a + b;        // 13 (덧셈)
int diff = a - b;       // 7 (뺄셈)
int product = a * b;    // 30 (곱셈)
int quotient = a / b;   // 3 (나눗셈)
int remainder = a % b;  // 1 (나머지)
```

### 비교 연산자

```csharp
bool isEqual = (a == b);      // false
bool isNotEqual = (a != b);   // true
bool isGreater = (a > b);     // true
bool isLess = (a < b);        // false
bool isGreaterEqual = (a >= b); // true
bool isLessEqual = (a <= b);    // false
```

### 논리 연산자

```csharp
bool x = true, y = false;

bool andResult = x && y;      // false (AND)
bool orResult = x || y;       // true (OR)
bool notResult = !x;          // false (NOT)
```

### 할당 연산자

```csharp
int num = 10;
num += 5;    // num = num + 5; (15)
num -= 3;    // num = num - 3; (12)
num *= 2;    // num = num * 2; (24)
num /= 4;    // num = num / 4; (6)
num %= 3;    // num = num % 3; (0)
```

## 제어문

### 조건문

#### if-else 문

```csharp
int score = 85;

if (score >= 90)
{
    Console.WriteLine("A학점");
}
else if (score >= 80)
{
    Console.WriteLine("B학점");
}
else if (score >= 70)
{
    Console.WriteLine("C학점");
}
else
{
    Console.WriteLine("F학점");
}
```

#### switch 문

```csharp
char grade = 'B';

switch (grade)
{
    case 'A':
        Console.WriteLine("우수");
        break;
    case 'B':
        Console.WriteLine("양호");
        break;
    case 'C':
        Console.WriteLine("보통");
        break;
    default:
        Console.WriteLine("미흡");
        break;
}
```

### 반복문

#### for 문

```csharp
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"반복 {i + 1}");
}
```

#### while 문

```csharp
int count = 0;
while (count < 3)
{
    Console.WriteLine($"카운트: {count}");
    count++;
}
```

#### do-while 문

```csharp
int number;
do
{
    Console.Write("1부터 10까지의 숫자를 입력하세요: ");
    number = int.Parse(Console.ReadLine());
} while (number < 1 || number > 10);
```

#### foreach 문

```csharp
string[] fruits = { "사과", "바나나", "오렌지" };
foreach (string fruit in fruits)
{
    Console.WriteLine(fruit);
}
```

## 배열과 컬렉션

### 배열

```csharp
// 1차원 배열
int[] numbers = { 1, 2, 3, 4, 5 };
int[] scores = new int[3]; // 크기 3의 배열

// 2차원 배열
int[,] matrix = new int[2, 3];
int[,] grid = { { 1, 2, 3 }, { 4, 5, 6 } };

// 가변 배열 (Jagged Array)
int[][] jaggedArray = new int[3][];
jaggedArray[0] = new int[2] { 1, 2 };
jaggedArray[1] = new int[3] { 3, 4, 5 };
jaggedArray[2] = new int[1] { 6 };
```

### 컬렉션

```csharp
using System.Collections.Generic;

// List<T>
List<string> names = new List<string>();
names.Add("김철수");
names.Add("이영희");
names.Add("박민수");

// Dictionary<TKey, TValue>
Dictionary<string, int> ages = new Dictionary<string, int>();
ages["김철수"] = 25;
ages["이영희"] = 30;

// HashSet<T>
HashSet<int> uniqueNumbers = new HashSet<int>();
uniqueNumbers.Add(1);
uniqueNumbers.Add(2);
uniqueNumbers.Add(1); // 중복이므로 추가 안됨
```

## 클래스와 객체

### 클래스 정의

```csharp
public class Person
{
    // 필드 (Fields)
    private string name;
    private int age;

    // 속성 (Properties)
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
        set
        {
            if (value >= 0)
                age = value;
        }
    }

    // 생성자 (Constructor)
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    // 메서드 (Method)
    public void Introduce()
    {
        Console.WriteLine($"안녕하세요, 저는 {name}이고 {age}세임");
    }
}
```

### 객체 생성 및 사용

```csharp
// 객체 생성
Person person1 = new Person("홍길동", 25);
Person person2 = new Person("김영희", 30);

// 속성 사용
person1.Name = "홍길동";
person1.Age = 25;

// 메서드 호출
person1.Introduce();
```

## 메서드

### 메서드 정의

```csharp
public class Calculator
{
    // 매개변수 없는 메서드
    public void SayHello()
    {
        Console.WriteLine("안녕하세요!");
    }

    // 매개변수가 있는 메서드
    public int Add(int a, int b)
    {
        return a + b;
    }

    // 기본값이 있는 매개변수
    public int Multiply(int a, int b = 2)
    {
        return a * b;
    }

    // ref 매개변수
    public void Swap(ref int a, ref int b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    // out 매개변수
    public bool TryDivide(int a, int b, out int result)
    {
        if (b != 0)
        {
            result = a / b;
            return true;
        }
        result = 0;
        return false;
    }

    // params 매개변수
    public int Sum(params int[] numbers)
    {
        int total = 0;
        foreach (int num in numbers)
        {
            total += num;
        }
        return total;
    }
}
```

### 메서드 오버로딩

```csharp
public class MathUtils
{
    public int Add(int a, int b)
    {
        return a + b;
    }

    public double Add(double a, double b)
    {
        return a + b;
    }

    public int Add(int a, int b, int c)
    {
        return a + b + c;
    }
}
```

## 상속과 다형성

### 상속

```csharp
// 부모 클래스
public class Animal
{
    protected string name;

    public Animal(string name)
    {
        this.name = name;
    }

    public virtual void MakeSound()
    {
        Console.WriteLine("동물이 소리를 냄");
    }

    public void Eat()
    {
        Console.WriteLine($"{name}이(가) 먹이를 먹음");
    }
}

// 자식 클래스
public class Dog : Animal
{
    public Dog(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{name}이(가) 멍멍 짖음");
    }

    public void WagTail()
    {
        Console.WriteLine($"{name}이(가) 꼬리를 흔듦");
    }
}

public class Cat : Animal
{
    public Cat(string name) : base(name)
    {
    }

    public override void MakeSound()
    {
        Console.WriteLine($"{name}이(가) 야옹 움");
    }
}
```

### 다형성

```csharp
// 다형성 사용
Animal[] animals = {
    new Dog("멍멍이"),
    new Cat("야옹이"),
    new Animal("일반동물")
};

foreach (Animal animal in animals)
{
    animal.MakeSound(); // 각각 다른 소리 출력
    animal.Eat();
}
```

## 예외 처리

### try-catch-finally

```csharp
try
{
    int number = int.Parse(Console.ReadLine());
    int result = 10 / number;
    Console.WriteLine($"결과: {result}");
}
catch (FormatException ex)
{
    Console.WriteLine("숫자 형식이 올바르지 않음");
}
catch (DivideByZeroException ex)
{
    Console.WriteLine("0으로 나눌 수 없음");
}
catch (Exception ex)
{
    Console.WriteLine($"오류 발생: {ex.Message}");
}
finally
{
    Console.WriteLine("프로그램을 종료함");
}
```

### 사용자 정의 예외

```csharp
public class InvalidAgeException : Exception
{
    public InvalidAgeException(string message) : base(message)
    {
    }
}

public class Person
{
    private int age;

    public int Age
    {
        get { return age; }
        set
        {
            if (value < 0 || value > 150)
                throw new InvalidAgeException("나이는 0-150 사이여야 함");
            age = value;
        }
    }
}
```

## 네임스페이스

### 네임스페이스 정의

```csharp
namespace MyCompany.MyProject
{
    public class Calculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }
    }
}

namespace MyCompany.MyProject.Utils
{
    public class StringHelper
    {
        public static string ToUpperCase(string input)
        {
            return input.ToUpper();
        }
    }
}
```

### 네임스페이스 사용

```csharp
using System;
using MyCompany.MyProject;
using MyCompany.MyProject.Utils;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();
        int result = calc.Add(5, 3);

        string upper = StringHelper.ToUpperCase("hello");

        Console.WriteLine($"결과: {result}");
        Console.WriteLine($"대문자: {upper}");
    }
}
```

## 추가 학습 자료

### 유용한 C# 기능들

- **LINQ**: 데이터 쿼리 기능
- **Lambda Expressions**: 익명 함수
- **Delegates**: 함수 포인터
- **Events**: 이벤트 처리
- **Async/Await**: 비동기 프로그래밍
- **Generics**: 제네릭 프로그래밍
- **Attributes**: 메타데이터
- **Reflection**: 런타임 타입 정보

### 개발 환경

- **Visual Studio**: Microsoft의 통합 개발 환경
- **Visual Studio Code**: 경량 코드 에디터
- **.NET CLI**: 명령줄 도구
- **NuGet**: 패키지 관리자

---

이 가이드는 C# 프로그래밍의 기초를 다룸 더 자세한 내용은 Microsoft 공식 문서나 추가 학습 자료를 참고
