# # C# programming University subject classes

## 목차

### 기초 개념

1. [C#이란?](#c이란)
2. [기본 문법](#기본-문법)
3. [데이터 타입](#데이터-타입)
4. [변수와 상수](#변수와-상수)
5. [연산자](#연산자)
6. [제어문](#제어문)
7. [배열과 컬렉션](#배열과-컬렉션)

### 객체지향 프로그래밍

8. [클래스와 객체](#클래스와-객체)
9. [메서드](#메서드)
10. [상속과 다형성](#상속과-다형성)
11. [인터페이스와 추상 클래스](#인터페이스와-추상-클래스)
12. [제네릭 프로그래밍](#제네릭-프로그래밍)

### 고급 기능

13. [LINQ와 람다 표현식](#linq와-람다-표현식)
14. [델리게이트와 이벤트](#델리게이트와-이벤트)
15. [비동기 프로그래밍 (Async/Await)](#비동기-프로그래밍-asyncawait)
16. [메모리 관리와 성능 최적화](#메모리-관리와-성능-최적화)
17. [리플렉션과 어트리뷰트](#리플렉션과-어트리뷰트)

### 디자인 패턴과 아키텍처

18. [디자인 패턴](#디자인-패턴)
19. [의존성 주입 (Dependency Injection)](#의존성-주입-dependency-injection)
20. [예외 처리](#예외-처리)
21. [네임스페이스](#네임스페이스)

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

## 인터페이스와 추상 클래스

### 인터페이스 (Interface)

인터페이스는 클래스가 구현해야 하는 계약을 정의하는 추상 타입입니다. 다중 상속을 지원하며, 구현 세부사항은 포함하지 않습니다.

```csharp
// 인터페이스 정의
public interface IShape
{
    double Area { get; }
    double Perimeter { get; }
    void Draw();
}

public interface IResizable
{
    void Resize(double factor);
}

// 인터페이스 구현
public class Circle : IShape, IResizable
{
    public double Radius { get; set; }

    public double Area => Math.PI * Radius * Radius;
    public double Perimeter => 2 * Math.PI * Radius;

    public void Draw()
    {
        Console.WriteLine($"원을 그립니다 (반지름: {Radius})");
    }

    public void Resize(double factor)
    {
        Radius *= factor;
    }
}

// 인터페이스 사용
IShape shape = new Circle { Radius = 5 };
shape.Draw();
Console.WriteLine($"면적: {shape.Area}");
```

### 추상 클래스 (Abstract Class)

추상 클래스는 완전하지 않은 클래스로, 직접 인스턴스화할 수 없으며 상속을 통해 사용됩니다.

```csharp
// 추상 클래스 정의
public abstract class Vehicle
{
    public string Brand { get; set; }
    public int Year { get; set; }

    // 일반 메서드
    public virtual void Start()
    {
        Console.WriteLine($"{Brand} 차량이 시동을 겁니다.");
    }

    // 추상 메서드 (반드시 구현해야 함)
    public abstract void Stop();

    // 가상 메서드 (선택적으로 오버라이드 가능)
    public virtual void DisplayInfo()
    {
        Console.WriteLine($"브랜드: {Brand}, 연식: {Year}");
    }
}

// 추상 클래스 상속
public class Car : Vehicle
{
    public int Doors { get; set; }

    public override void Stop()
    {
        Console.WriteLine("브레이크를 밟아 차량을 정지시킵니다.");
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"문 개수: {Doors}");
    }
}

public class Motorcycle : Vehicle
{
    public bool HasSidecar { get; set; }

    public override void Stop()
    {
        Console.WriteLine("핸들 브레이크를 당겨 오토바이를 정지시킵니다.");
    }
}
```

### 인터페이스 vs 추상 클래스

| 특징            | 인터페이스        | 추상 클래스             |
| --------------- | ----------------- | ----------------------- |
| **다중 상속**   | 지원              | 지원 안함               |
| **구현**        | 메서드 시그니처만 | 구현된 메서드 포함 가능 |
| **접근 제한자** | public만          | 모든 접근 제한자        |
| **필드**        | 상수만            | 모든 필드 타입          |
| **생성자**      | 없음              | 있음                    |

## 제네릭 프로그래밍

### 제네릭 클래스

제네릭을 사용하면 타입에 독립적인 재사용 가능한 코드를 작성할 수 있습니다.

```csharp
// 제네릭 클래스 정의
public class GenericRepository<T> where T : class
{
    private List<T> items = new List<T>();

    public void Add(T item)
    {
        items.Add(item);
    }

    public T GetById(int id)
    {
        // 실제 구현에서는 ID 속성을 가진 엔티티를 가정
        return items.FirstOrDefault();
    }

    public IEnumerable<T> GetAll()
    {
        return items.AsReadOnly();
    }

    public void Remove(T item)
    {
        items.Remove(item);
    }
}

// 사용 예제
var userRepo = new GenericRepository<User>();
var productRepo = new GenericRepository<Product>();

userRepo.Add(new User { Id = 1, Name = "홍길동" });
productRepo.Add(new Product { Id = 1, Name = "노트북", Price = 1000000 });
```

### 제네릭 메서드

```csharp
public class Utility
{
    // 제네릭 메서드
    public static T Max<T>(T a, T b) where T : IComparable<T>
    {
        return a.CompareTo(b) > 0 ? a : b;
    }

    // 제네릭 확장 메서드
    public static void PrintItems<T>(this IEnumerable<T> items)
    {
        foreach (var item in items)
        {
            Console.WriteLine(item);
        }
    }
}

// 사용
int maxInt = Utility.Max(10, 20);
string maxString = Utility.Max("apple", "banana");

var numbers = new List<int> { 1, 2, 3, 4, 5 };
numbers.PrintItems(); // 확장 메서드 사용
```

### 제네릭 제약 조건

```csharp
// where T : struct - 값 타입만
public class ValueContainer<T> where T : struct
{
    public T Value { get; set; }
}

// where T : class - 참조 타입만
public class ReferenceContainer<T> where T : class
{
    public T Value { get; set; }
}

// where T : new() - 매개변수 없는 생성자가 있는 타입만
public class Factory<T> where T : new()
{
    public T Create()
    {
        return new T();
    }
}

// where T : IComparable<T> - 특정 인터페이스를 구현한 타입만
public class Sorter<T> where T : IComparable<T>
{
    public void Sort(T[] array)
    {
        Array.Sort(array);
    }
}
```

## LINQ와 람다 표현식

### LINQ (Language Integrated Query)

LINQ는 데이터 쿼리를 위한 통합된 문법을 제공합니다.

```csharp
using System.Linq;

// 데이터 소스
var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
var people = new[]
{
    new { Name = "김철수", Age = 25, City = "서울" },
    new { Name = "이영희", Age = 30, City = "부산" },
    new { Name = "박민수", Age = 35, City = "서울" },
    new { Name = "최지영", Age = 28, City = "대구" }
};

// LINQ 쿼리 (메서드 문법)
var evenNumbers = numbers.Where(n => n % 2 == 0);
var adults = people.Where(p => p.Age >= 30);
var seoulPeople = people.Where(p => p.City == "서울");

// LINQ 쿼리 (쿼리 문법)
var query = from p in people
            where p.Age >= 30
            orderby p.Name
            select new { p.Name, p.Age };

// 집계 함수
var sum = numbers.Sum();
var average = numbers.Average();
var max = numbers.Max();
var count = people.Count(p => p.City == "서울");

// 그룹화
var groupedByCity = people.GroupBy(p => p.City);
foreach (var group in groupedByCity)
{
    Console.WriteLine($"도시: {group.Key}, 인원: {group.Count()}");
}
```

### 람다 표현식

람다 표현식은 익명 함수를 간결하게 표현하는 방법입니다.

```csharp
// 람다 표현식 기본 문법
Func<int, int> square = x => x * x;
Func<int, int, int> add = (x, y) => x + y;
Action<string> print = message => Console.WriteLine(message);

// 사용
int result = square(5); // 25
int sum = add(3, 4);    // 7
print("Hello World");   // Hello World

// LINQ와 함께 사용
var numbers = new[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

// 짝수만 필터링
var evens = numbers.Where(n => n % 2 == 0);

// 제곱값 계산
var squares = numbers.Select(n => n * n);

// 조건에 맞는 첫 번째 요소 찾기
var firstEven = numbers.FirstOrDefault(n => n % 2 == 0);

// 모든 요소가 조건을 만족하는지 확인
bool allPositive = numbers.All(n => n > 0);

// 어떤 요소라도 조건을 만족하는지 확인
bool anyEven = numbers.Any(n => n % 2 == 0);
```

## 델리게이트와 이벤트

### 델리게이트 (Delegate)

델리게이트는 메서드를 참조하는 타입으로, 함수 포인터와 유사합니다.

```csharp
// 델리게이트 정의
public delegate int MathOperation(int a, int b);
public delegate void NotifyDelegate(string message);

// 델리게이트 사용
public class Calculator
{
    public static int Add(int a, int b) => a + b;
    public static int Multiply(int a, int b) => a * b;

    public static void Calculate(int a, int b, MathOperation operation)
    {
        int result = operation(a, b);
        Console.WriteLine($"결과: {result}");
    }
}

// 사용 예제
MathOperation addOp = Calculator.Add;
MathOperation multiplyOp = Calculator.Multiply;

Calculator.Calculate(5, 3, addOp);        // 결과: 8
Calculator.Calculate(5, 3, multiplyOp);   // 결과: 15

// 델리게이트 체인
MathOperation chain = addOp + multiplyOp;
chain(5, 3); // Add와 Multiply가 순차적으로 실행됨
```

### Func와 Action

.NET에서 제공하는 내장 델리게이트 타입들입니다.

```csharp
// Func<T, TResult> - 반환값이 있는 델리게이트
Func<int, int, int> add = (a, b) => a + b;
Func<string, int> getLength = s => s.Length;

// Action<T> - 반환값이 없는 델리게이트
Action<string> print = s => Console.WriteLine(s);
Action<int, int> printSum = (a, b) => Console.WriteLine(a + b);

// 사용
int result = add(5, 3);
int length = getLength("Hello");
print("Hello World");
printSum(5, 3);
```

### 이벤트 (Event)

이벤트는 특정 상황이 발생했을 때 구독자들에게 알림을 보내는 메커니즘입니다.

```csharp
// 이벤트 발행자
public class Publisher
{
    public event EventHandler<string> DataChanged;
    public event Action<int> ProgressChanged;

    private string data;
    public string Data
    {
        get => data;
        set
        {
            data = value;
            OnDataChanged(data);
        }
    }

    protected virtual void OnDataChanged(string newData)
    {
        DataChanged?.Invoke(this, newData);
    }

    public void UpdateProgress(int progress)
    {
        ProgressChanged?.Invoke(progress);
    }
}

// 이벤트 구독자
public class Subscriber
{
    public void Subscribe(Publisher publisher)
    {
        publisher.DataChanged += OnDataChanged;
        publisher.ProgressChanged += OnProgressChanged;
    }

    public void Unsubscribe(Publisher publisher)
    {
        publisher.DataChanged -= OnDataChanged;
        publisher.ProgressChanged -= OnProgressChanged;
    }

    private void OnDataChanged(object sender, string data)
    {
        Console.WriteLine($"데이터가 변경됨: {data}");
    }

    private void OnProgressChanged(int progress)
    {
        Console.WriteLine($"진행률: {progress}%");
    }
}

// 사용 예제
var publisher = new Publisher();
var subscriber = new Subscriber();

subscriber.Subscribe(publisher);

publisher.Data = "새로운 데이터";
publisher.UpdateProgress(50);
```

## 비동기 프로그래밍 (Async/Await)

### async/await 기본

비동기 프로그래밍을 통해 UI 블로킹 없이 장시간 작업을 처리할 수 있습니다.

```csharp
using System.Net.Http;
using System.Threading.Tasks;

public class AsyncExample
{
    private static readonly HttpClient httpClient = new HttpClient();

    // 비동기 메서드 정의
    public static async Task<string> DownloadContentAsync(string url)
    {
        try
        {
            Console.WriteLine($"다운로드 시작: {url}");

            // 비동기 HTTP 요청
            string content = await httpClient.GetStringAsync(url);

            Console.WriteLine("다운로드 완료");
            return content;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"다운로드 실패: {ex.Message}");
            return null;
        }
    }

    // 여러 비동기 작업 병렬 처리
    public static async Task<string[]> DownloadMultipleAsync(string[] urls)
    {
        var tasks = urls.Select(url => DownloadContentAsync(url));
        return await Task.WhenAll(tasks);
    }

    // 비동기 메서드 호출
    public static async Task Main()
    {
        string url = "https://api.github.com/users/octocat";
        string content = await DownloadContentAsync(url);

        if (content != null)
        {
            Console.WriteLine($"콘텐츠 길이: {content.Length}");
        }
    }
}
```

### Task와 Task<T>

```csharp
public class TaskExample
{
    // Task<T> - 반환값이 있는 비동기 작업
    public static async Task<int> CalculateAsync(int a, int b)
    {
        // 시뮬레이션된 장시간 작업
        await Task.Delay(2000);
        return a + b;
    }

    // Task - 반환값이 없는 비동기 작업
    public static async Task ProcessDataAsync()
    {
        Console.WriteLine("데이터 처리 시작");
        await Task.Delay(1000);
        Console.WriteLine("데이터 처리 완료");
    }

    // 비동기 작업 조합
    public static async Task Main()
    {
        // 순차 실행
        int result1 = await CalculateAsync(5, 3);
        int result2 = await CalculateAsync(10, 7);
        Console.WriteLine($"결과: {result1 + result2}");

        // 병렬 실행
        var task1 = CalculateAsync(5, 3);
        var task2 = CalculateAsync(10, 7);
        var task3 = ProcessDataAsync();

        await Task.WhenAll(task1, task2, task3);

        Console.WriteLine($"병렬 결과: {task1.Result + task2.Result}");
    }
}
```

## 메모리 관리와 성능 최적화

### 가비지 컬렉션 이해

C#은 자동 메모리 관리를 제공하지만, 성능을 위해 가비지 컬렉션을 이해해야 합니다.

```csharp
public class MemoryManagement
{
    // IDisposable 구현으로 리소스 관리
    public class ResourceManager : IDisposable
    {
        private bool disposed = false;
        private IntPtr handle;

        public ResourceManager()
        {
            // 리소스 할당
            handle = Marshal.AllocHGlobal(1024);
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposed)
            {
                if (disposing)
                {
                    // 관리되는 리소스 정리
                }

                // 비관리되는 리소스 정리
                if (handle != IntPtr.Zero)
                {
                    Marshal.FreeHGlobal(handle);
                    handle = IntPtr.Zero;
                }

                disposed = true;
            }
        }

        ~ResourceManager()
        {
            Dispose(false);
        }
    }

    // using 문으로 자동 리소스 관리
    public static void UseResource()
    {
        using (var resource = new ResourceManager())
        {
            // 리소스 사용
            Console.WriteLine("리소스 사용 중...");
        } // 자동으로 Dispose() 호출
    }
}
```

### 성능 최적화 기법

```csharp
public class PerformanceOptimization
{
    // StringBuilder 사용 (문자열 연결 최적화)
    public static string BuildString(int count)
    {
        var sb = new StringBuilder();
        for (int i = 0; i < count; i++)
        {
            sb.Append($"Item {i}, ");
        }
        return sb.ToString();
    }

    // 배열 vs List 성능 비교
    public static void ArrayVsList()
    {
        const int size = 1000000;

        // 배열 - 더 빠름
        var array = new int[size];
        for (int i = 0; i < size; i++)
        {
            array[i] = i;
        }

        // List - 더 유연하지만 약간 느림
        var list = new List<int>(size); // 초기 용량 설정으로 성능 향상
        for (int i = 0; i < size; i++)
        {
            list.Add(i);
        }
    }

    // LINQ 최적화
    public static void OptimizeLinq()
    {
        var numbers = Enumerable.Range(1, 1000000);

        // 비효율적 - 여러 번 순회
        var result1 = numbers.Where(n => n % 2 == 0)
                           .Where(n => n > 100)
                           .Select(n => n * 2)
                           .ToList();

        // 효율적 - 한 번에 처리
        var result2 = numbers.Where(n => n % 2 == 0 && n > 100)
                           .Select(n => n * 2)
                           .ToList();
    }
}
```

## 리플렉션과 어트리뷰트

### 리플렉션 (Reflection)

리플렉션을 통해 런타임에 타입 정보를 조사하고 조작할 수 있습니다.

```csharp
using System.Reflection;

public class ReflectionExample
{
    public string Name { get; set; }
    public int Age { get; set; }
    private string secret = "비밀 정보";

    public void DisplayInfo()
    {
        Console.WriteLine($"이름: {Name}, 나이: {Age}");
    }

    public static void DemonstrateReflection()
    {
        var obj = new ReflectionExample { Name = "홍길동", Age = 25 };
        Type type = obj.GetType();

        // 속성 정보 조사
        PropertyInfo[] properties = type.GetProperties();
        foreach (var prop in properties)
        {
            Console.WriteLine($"속성: {prop.Name}, 타입: {prop.PropertyType.Name}");
            Console.WriteLine($"값: {prop.GetValue(obj)}");
        }

        // 메서드 호출
        MethodInfo method = type.GetMethod("DisplayInfo");
        method.Invoke(obj, null);

        // private 필드 접근
        FieldInfo field = type.GetField("secret", BindingFlags.NonPublic | BindingFlags.Instance);
        string secretValue = (string)field.GetValue(obj);
        Console.WriteLine($"비밀: {secretValue}");
    }
}
```

### 어트리뷰트 (Attributes)

어트리뷰트는 코드에 메타데이터를 추가하는 방법입니다.

```csharp
// 커스텀 어트리뷰트 정의
[AttributeUsage(AttributeTargets.Property | AttributeTargets.Method)]
public class ValidationAttribute : Attribute
{
    public string ErrorMessage { get; }
    public bool IsRequired { get; set; }

    public ValidationAttribute(string errorMessage)
    {
        ErrorMessage = errorMessage;
    }
}

[AttributeUsage(AttributeTargets.Class)]
public class AuthorAttribute : Attribute
{
    public string Name { get; }
    public string Version { get; set; }

    public AuthorAttribute(string name)
    {
        Name = name;
    }
}

// 어트리뷰트 사용
[Author("홍길동", Version = "1.0")]
public class User
{
    [Validation("이름은 필수입니다", IsRequired = true)]
    public string Name { get; set; }

    [Validation("나이는 0보다 커야 합니다")]
    public int Age { get; set; }

    [Validation("이메일 형식이 올바르지 않습니다")]
    public string Email { get; set; }
}

// 어트리뷰트 정보 조사
public static void InspectAttributes()
{
    Type userType = typeof(User);

    // 클래스 어트리뷰트
    var authorAttr = userType.GetCustomAttribute<AuthorAttribute>();
    if (authorAttr != null)
    {
        Console.WriteLine($"작성자: {authorAttr.Name}, 버전: {authorAttr.Version}");
    }

    // 속성 어트리뷰트
    var properties = userType.GetProperties();
    foreach (var prop in properties)
    {
        var validationAttr = prop.GetCustomAttribute<ValidationAttribute>();
        if (validationAttr != null)
        {
            Console.WriteLine($"{prop.Name}: {validationAttr.ErrorMessage}");
        }
    }
}
```

## 디자인 패턴

### 싱글톤 패턴 (Singleton Pattern)

```csharp
public class Singleton
{
    private static Singleton instance;
    private static readonly object lockObject = new object();

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (instance == null)
            {
                lock (lockObject)
                {
                    if (instance == null)
                    {
                        instance = new Singleton();
                    }
                }
            }
            return instance;
        }
    }

    public void DoSomething()
    {
        Console.WriteLine("싱글톤 작업 수행");
    }
}
```

### 팩토리 패턴 (Factory Pattern)

```csharp
// 제품 인터페이스
public interface IProduct
{
    void Display();
}

// 구체적인 제품들
public class ConcreteProductA : IProduct
{
    public void Display() => Console.WriteLine("제품 A");
}

public class ConcreteProductB : IProduct
{
    public void Display() => Console.WriteLine("제품 B");
}

// 팩토리 클래스
public class ProductFactory
{
    public static IProduct CreateProduct(string type)
    {
        return type.ToLower() switch
        {
            "a" => new ConcreteProductA(),
            "b" => new ConcreteProductB(),
            _ => throw new ArgumentException("지원하지 않는 제품 타입")
        };
    }
}
```

### 옵저버 패턴 (Observer Pattern)

```csharp
// 옵저버 인터페이스
public interface IObserver
{
    void Update(string message);
}

// 주제 인터페이스
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

// 구체적인 주제
public class NewsAgency : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string news;

    public string News
    {
        get => news;
        set
        {
            news = value;
            Notify();
        }
    }

    public void Attach(IObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in observers)
        {
            observer.Update(news);
        }
    }
}

// 구체적인 옵저버
public class NewsChannel : IObserver
{
    public string Name { get; set; }

    public NewsChannel(string name)
    {
        Name = name;
    }

    public void Update(string message)
    {
        Console.WriteLine($"{Name}: {message}");
    }
}
```

## 의존성 주입 (Dependency Injection)

### 기본 의존성 주입

```csharp
// 서비스 인터페이스
public interface IEmailService
{
    void SendEmail(string to, string subject, string body);
}

public interface IUserService
{
    void CreateUser(string name, string email);
}

// 서비스 구현
public class EmailService : IEmailService
{
    public void SendEmail(string to, string subject, string body)
    {
        Console.WriteLine($"이메일 전송: {to} - {subject}");
    }
}

public class UserService : IUserService
{
    private readonly IEmailService emailService;

    public UserService(IEmailService emailService)
    {
        this.emailService = emailService;
    }

    public void CreateUser(string name, string email)
    {
        Console.WriteLine($"사용자 생성: {name}");
        emailService.SendEmail(email, "환영합니다", "계정이 생성되었습니다.");
    }
}

// 의존성 주입 컨테이너 (간단한 구현)
public class DIContainer
{
    private readonly Dictionary<Type, object> services = new Dictionary<Type, object>();

    public void Register<TInterface, TImplementation>()
        where TImplementation : class, TInterface, new()
    {
        services[typeof(TInterface)] = new TImplementation();
    }

    public T Resolve<T>()
    {
        return (T)services[typeof(T)];
    }
}

// 사용 예제
public static void Main()
{
    var container = new DIContainer();
    container.Register<IEmailService, EmailService>();
    container.Register<IUserService, UserService>();

    var userService = container.Resolve<IUserService>();
    userService.CreateUser("홍길동", "hong@example.com");
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

### 고급 C# 기능들

#### C# 8.0+ 최신 기능

- **Nullable Reference Types**: null 안전성 강화
- **Pattern Matching**: switch 표현식과 패턴 매칭
- **Records**: 불변 데이터 타입
- **Init-only Properties**: 초기화 전용 속성
- **Range와 Index**: 배열 슬라이싱
- **Default Interface Methods**: 인터페이스 기본 구현

#### C# 9.0+ 기능

- **Top-level Programs**: Main 메서드 없이 프로그램 작성
- **Target-typed new**: 타입 추론을 통한 객체 생성
- **Pattern Matching 개선**: and, or, not 패턴
- **Native-sized Integers**: nint, nuint 타입

### 실무에서 자주 사용하는 라이브러리

#### 데이터베이스

- **Entity Framework Core**: ORM 프레임워크
- **Dapper**: 경량 ORM
- **SQL Server**: Microsoft 데이터베이스

#### 웹 개발

- **ASP.NET Core**: 웹 API 및 MVC 프레임워크
- **Blazor**: 웹 UI 프레임워크
- **SignalR**: 실시간 통신

#### 테스팅

- **xUnit**: 단위 테스트 프레임워크
- **NUnit**: 대안 테스트 프레임워크
- **Moq**: 모킹 라이브러리

#### 로깅 및 모니터링

- **Serilog**: 구조화된 로깅
- **NLog**: 로깅 프레임워크
- **Application Insights**: 클라우드 모니터링

### 성능 최적화 고급 기법

#### 메모리 최적화

```csharp
// Span<T>와 Memory<T> 사용
public void ProcessData(Span<byte> data)
{
    for (int i = 0; i < data.Length; i++)
    {
        data[i] = (byte)(data[i] ^ 0xFF);
    }
}

// ArrayPool 사용으로 GC 압박 감소
var pool = ArrayPool<int>.Shared;
var array = pool.Rent(1000);
try
{
    // 배열 사용
}
finally
{
    pool.Return(array);
}
```

#### 병렬 처리

```csharp
// Parallel.For 사용
Parallel.For(0, 1000, i =>
{
    // 병렬로 실행될 작업
});

// PLINQ 사용
var results = numbers.AsParallel()
    .Where(n => n % 2 == 0)
    .Select(n => n * n)
    .ToList();
```

### 아키텍처 패턴

#### Clean Architecture

- **Domain Layer**: 비즈니스 로직
- **Application Layer**: 유스케이스
- **Infrastructure Layer**: 외부 의존성
- **Presentation Layer**: UI

#### CQRS (Command Query Responsibility Segregation)

- **Command**: 상태를 변경하는 작업
- **Query**: 데이터를 조회하는 작업
- **MediatR**: CQRS 패턴 구현 라이브러리

### 개발 환경 및 도구

#### IDE 및 에디터

- **Visual Studio 2022**: 최신 통합 개발 환경
- **Visual Studio Code**: 경량 에디터 + C# 확장
- **JetBrains Rider**: 크로스 플랫폼 IDE

#### 빌드 및 배포

- **.NET CLI**: 명령줄 도구
- **MSBuild**: 빌드 시스템
- **Docker**: 컨테이너화
- **Azure DevOps**: CI/CD 파이프라인

#### 패키지 관리

- **NuGet**: .NET 패키지 관리자
- **Paket**: 대안 패키지 관리자
- **MyGet**: 프라이빗 패키지 저장소

### 학습 로드맵

#### 초급 (1-3개월)

1. C# 기본 문법 및 OOP 개념
2. .NET 기본 라이브러리 사용
3. 간단한 콘솔 애플리케이션 개발

#### 중급 (3-6개월)

1. LINQ, 람다 표현식 마스터
2. 비동기 프로그래밍 이해
3. Entity Framework 사용
4. 단위 테스트 작성

#### 고급 (6-12개월)

1. 디자인 패턴 적용
2. 성능 최적화 기법
3. 마이크로서비스 아키텍처
4. 클라우드 배포 (Azure/AWS)

#### 전문가 (1년+)

1. 오픈소스 기여
2. 아키텍처 설계
3. 팀 리딩 및 멘토링
4. 컨퍼런스 발표

### 유용한 리소스

#### 공식 문서

- [Microsoft C# 문서](https://docs.microsoft.com/ko-kr/dotnet/csharp/)
- [.NET API 참조](https://docs.microsoft.com/ko-kr/dotnet/api/)
- [C# 언어 사양](https://docs.microsoft.com/ko-kr/dotnet/csharp/language-reference/language-specification/)

#### 커뮤니티

- [Stack Overflow](https://stackoverflow.com/questions/tagged/c%23)
- [Reddit r/csharp](https://www.reddit.com/r/csharp/)
- [C# Discord 서버](https://discord.gg/csharp)

#### 학습 자료

- [Pluralsight C# 코스](https://www.pluralsight.com/browse/software-development/c-sharp)
- [Udemy C# 강의](https://www.udemy.com/topic/c-sharp/)
- [YouTube C# 채널들](https://www.youtube.com/results?search_query=c%23+tutorial)

---
