/* Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2


Console.Write("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
int count = 0;
for (int i = 0; i < size; i++)
{
    array [i] = new Random().Next(100,1000);
    if (array[i] % 2 == 0) count++;
}
Console.WriteLine($" В массиве:[{String.Join(",",array)}] {count} чётных чисел");


Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0

Console.Write("Введите размер массива:");
int size = Convert.ToInt32(Console.ReadLine());
int [] array = new int [size];
int sum = 0;
for (int i = 1; i < size; i++)
{
    array [i] = new Random().Next(1,20);
    if ( i % 2 != 0) sum += array[i];
}
Console.WriteLine($"Сумма элементов массива[{String.Join(",", array)}], стоящих на нечетных позициях равна {sum}");

Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементом массива.
[3 7 22 2 78] -> 76
*/

Console.WriteLine("Введите размер массива");
int size = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[size];
FillArrayRandomNumbers(numbers);
Console.WriteLine("Массив");
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int z = 0; z < size; z++)
{
    if (numbers[z] > max) max = numbers[z];
    if (numbers[z] < min) min = numbers[z];
        
}

Console.WriteLine($"Разница между максимальным значением {max} и минимальным значением {min} = {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000));
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


