// Задание 1
using System.Diagnostics.CodeAnalysis;

PrintLine();
Console.WriteLine("Отчёт");
PrintLine();

PrintHeader("123");

Console.WriteLine(Max(5, 10));
Console.WriteLine(Max(100, 99));

Console.WriteLine(IsEven(4));
Console.WriteLine(IsEven(7));
Console.WriteLine(IsEven(0));

static void PrintLine()
{
    Console.WriteLine("^_^ ^_^ ^_^ ^_^ ^_^");
}

static void PrintHeader(string title)
{
    PrintLine();
    Console.WriteLine($"{title}");
    PrintLine();
}


static bool IsEven(int n)
{
    if (n % 2 == 0)
    {
        return true;
    } else
    {
        return false;
    }
}

int[] m = { 120, 45, 300, 80, 15, 210 };
Console.WriteLine(Average(m));
Console.WriteLine(CountGreater(m, 100));

static double Average(int[] arr)
{
    return Convert.ToDouble(arr.Sum()) / Convert.ToDouble(arr.Length);
}

static int CountGreater(int[] arr, int limit)
{
    int c = 0;
    foreach (int i in arr)
    {
        if (i > limit)
        {
            c ++;
        }
    }
    return c;
}

Console.WriteLine(ToFahrenheit(0));
Console.WriteLine(ToFahrenheit(100));
Console.WriteLine(ToFahrenheit(37));

static double ToFahrenheit(double celsius)
{
    return celsius * 9 / 5 + 32;
}

// самостоятельная

Console.WriteLine(Factorial(5));
for (int i = 2; i <= 50; i++)
{
    Console.WriteLine(IsPrime(i));
}

static long Factorial(int n)
{
    int f = 1;
    for (int i = 2; i <= n; i++)
    {
        f *= i;
    }
    return f;
}

static bool IsPrime(int n)
{
    if (n < 2) {
        return false;
    }
    for (int i = 2; i < n; i++)
    {
        if (n % i == 0)
            return false;
    }
    return true;
}
int menu;
Console.WriteLine("Введите a и b");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
do
{
    Console.WriteLine("\nВыберите действие:");
    Console.WriteLine("1 - Сумма двух чисел");
    Console.WriteLine("2 - большее из двух чисел");
    Console.WriteLine("3 - Факториал");
    Console.WriteLine("0 - Выход");

    if (!int.TryParse(Console.ReadLine(), out menu))
    {
        Console.WriteLine("Ошибка: введите число!");
        continue;
    }
    switch (menu)
    {
        case 1: 
            Console.WriteLine(Sum(a, b));
            continue;
        case 2: 
            Console.WriteLine(Max(a, b));
            continue;
        case 3:
            Console.WriteLine($"Факториал a: {Factorial(a)}");
            Console.WriteLine($"Факториал b: {Factorial(b)}");
            continue;
        case 0: 
            Console.WriteLine("Выход");
            break;
        default:
            Console.WriteLine("Такого числа нет");
            continue;
    };
    
 } while (menu != 0);

 static int Max(int a, int b)
{
    if (a > b)
    {
        return a;
    }
    else
    {
        return b;
    }
}

static int Sum(int a, int b)
{
    return a + b;
}