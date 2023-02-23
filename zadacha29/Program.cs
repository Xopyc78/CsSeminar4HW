// Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
// 1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
// 6, 1, 33 -> [6, 1, 33]
int[] GetArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Convert.ToInt32(Console.ReadLine());
    }
    return array;
}
Console.WriteLine("Введите через клавишу Enter восемь чисел будущего массива");
int[] resultArray = GetArray(8);
Console.WriteLine($"Массив из восьми элементов: [ {String.Join(", ", resultArray)} ]");