// Задача 45: Напишите программу, которая будет создавать 
// копию заданного массива с помощью поэлементного 
// копирования.

int GetNum(string message)
{
    Console.Write(message);
    return int.Parse(Console.ReadLine()!);
}

int[] FillArray(int arrSize, int arrMinValue, int arrMaxValue)
{
    int[] array = new int[arrSize];
    for (int i = 0; i < arrSize; i++)
    {
        array[i] = new Random().Next(arrMinValue, arrMaxValue + 1);
    }
    return array;
}

int[] CopyArray(int[] array)
{
    int[] newArray = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
       newArray[i] = array[i]; 
    }
    return newArray;
}

int size = GetNum("Введите длину массива: ");
int min = GetNum("Введите нижнюю границу массива: ");
int max = GetNum("Введите верхнюю границу массива: ");

int[] startArray = FillArray(size, min, max);
Console.WriteLine($"З а д а н н ы й  массив {string.Join(" ", startArray)}");
int [] resultArray = CopyArray(startArray); 
Console.WriteLine($"Копия заданного массива {string.Join(" ", resultArray)}");
