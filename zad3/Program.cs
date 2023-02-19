﻿/*Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
Console.Write("Введите размер массива: ");
int Length = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double [Length];
FillArrayRandomNumbers(numbers);
Console.Write("Массив: ");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
    {
        max = numbers[i];
    }
    if (numbers[i] < min)
    {
        min = numbers[i];
    }
}
Console.WriteLine($"всего {numbers.Length} чисел. Максимальное = {max}, Минимальное = {min}");
Console.WriteLine($"Разница между максимальным и минимальным равна {max - min}");
void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
    }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
    Console.Write(numbers[i] + " ");
    }
    Console.Write("]");
    Console.WriteLine();
}