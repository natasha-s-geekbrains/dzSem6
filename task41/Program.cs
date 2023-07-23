// Задача 41: Пользователь вводит с клавиатуры M чисел. 
// Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

string GetNumbersSet(string message)
{
    Console.Write(message);
    return Console.ReadLine()!;
}

void CountPositiveNum(string numbers)
{
    numbers = numbers.Replace(" ", "");
    Console.WriteLine(numbers);

    string[] set = numbers.Split(',');

    int count = 0;

    for (int i = 0; i < set.Length; i++)
    {
        if (int.Parse(set[i]) > 0) { count++; }
    }
    Console.WriteLine($"Количество введенных чисел больше нуля равно {count}.");
}

string numbersSet = GetNumbersSet("Введите любое количество чисел через запятую с пробелом: "); // такой формат виден в примере к задаче
CountPositiveNum(numbersSet);
