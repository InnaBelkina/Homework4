// Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

Console.Clear();
int Degree(int number1, int number2)
{
    int result = 1;
    for (int i = 1; i <= number2; i++)
    {
        result = result * number1;
    }
    return result;
}

Console.WriteLine("Введите число a ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите число b ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"Число {a} в степени {b} = {Degree(a, b)}");