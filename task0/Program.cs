// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) 
// и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.WriteLine("Введите число A: ");
long a = Convert.ToInt64(Console.ReadLine());

Console.WriteLine("Введите число B: ");
long b = Convert.ToInt64(Console.ReadLine());

long GetPower(long a1, long b1)
{
    long power = 1;
    for (long i = 1; i <= Math.Abs(b1); i++)
    {
        power = power * a1;
    }
    return power;
}

long result = GetPower(a, b);
Console.WriteLine($"Число {a} в степени |{b}| = {result}");
