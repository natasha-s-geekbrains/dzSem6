// Задача 44: Не используя рекурсию, выведите первые N чисел 
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

void GetFibonacciRow(int n)
{
    int fib1 = 0;
    int fib2 = 1;

    if (n == 1) { Console.Write(fib1); }
    else if (n == 2) { Console.Write($"{fib1} {fib2}"); }
    else
    {
        Console.Write($"{fib1} {fib2}");
        int count = 3;
        while (count <= n)
        {
            int fibNext = fib1 + fib2;
            Console.Write($" {fibNext}");
            fib1 = fib2;
            fib2 = fibNext;
            count++;
        }
    }
}

int N = GetNum("Введите значение N: ");
GetFibonacciRow(N);



