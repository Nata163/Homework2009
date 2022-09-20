// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.

int[] GetArray(int size)
{
    int[] arr = new int[size];
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Введите элемент массива с индексом {i}");
        arr[i] = int.Parse(Console.ReadLine());
    }
    return arr;
}

int GetCountNumbersUpZero(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (arr[i] > 0)
        {
            count = count + 1;
        }
    }
    return count;
}

Console.WriteLine("Сколько чисел будет введено?");
int count = int.Parse(Console.ReadLine());
int[] array = GetArray(count);
int result = GetCountNumbersUpZero(array);
Console.WriteLine($"Введено {result} чисел больше 0.");
