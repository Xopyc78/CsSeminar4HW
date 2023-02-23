// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и 
// возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16
Console.Write("Введите число А ");
int firstNumber = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите число B ");
int secondNumber = Convert.ToInt32(Console.ReadLine());
int Pow (int a,int b)
{
    int pow = 1;
    for (int i = 0; i < secondNumber; i++)
    {
        pow=pow*firstNumber;
    }
    return pow;
}

Console.WriteLine($"Число {firstNumber} в степени {secondNumber} = {Pow(firstNumber,secondNumber)}");