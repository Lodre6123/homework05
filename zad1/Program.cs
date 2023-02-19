/*Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.

[345, 897, 568, 234] -> 2
*/
Console.WriteLine("Введите длину массива; ");
int Length = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int [Length];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Array: ");
PrintArray(numbers);
int count = 0;
for(int i = 0; i < numbers.Length; i++)
if (numbers[i] % 2 == 0)
count++;
Console.WriteLine($"всего {numbers.Length} чисел, {count} из них чётные");
void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
    }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
    {
        Console.Write(numbers[i] + " ");
    }
    Console.Write("]");    
}