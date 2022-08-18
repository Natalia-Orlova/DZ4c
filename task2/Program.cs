// Задача 29: Напишите программу, которая задаёт массив 
// из 8 элементов и выводит их на экран.

// 1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

Console.WriteLine("Введите размер массива: ");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 0)
{
    Console.WriteLine("Введено недопустимое значение: ");
    return;
}

int [] FillArray (int length)
{
    int [] array = new int [length];
    Random rnd = new Random();
    for (int i = 0; i < length; i++)
    {
        array[i] = rnd.Next(0,100);
    }
    return array;
}
int[] result = FillArray(n);

void PrintArray (int[] array1)
{
    Console.Write("[ ");
    for (int i = 0; i < array1.Length - 1; i++)
    {
        Console.Write($"{array1[i]}, ");
    }
    Console.Write($"{array1[array1.Length - 1]} ]");
}
PrintArray(result);