//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях. [3, 7, 23, 12] -> 19 [-4, -6, 89, 6] -> 0
int[] ArrayCreation(int len)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(1, 10);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    int len = arr.Length;
    for(int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int findNegativeSum(int[] arr)
{
    int sum = 0;
    for(int i = 0; i < arr.Length; i++)
    if(arr[i] % 2 != 1)
    sum += arr[i];
    return sum;
}
int[] myarr = ArrayCreation(5);
PrintArray(myarr);
int sum = findNegativeSum(myarr);
Console.WriteLine(sum);
Console.WriteLine($"Сумма нечетных чисел в массиве: {sum}");

// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве. [345, 897, 568, 234] -> 2

int[] ArrayCreation(int len)
{
    int[] arr = new int[len];
    for(int i = 0; i < len; i++)
    {
        arr[i] = new Random().Next(100, 1000);
    }
    return arr;
}
void PrintArray(int[] arr)
{
    int len = arr.Length;
    for(int i = 0; i < len; i++)
    {
        Console.Write($"{arr[i]} ");
    }
    Console.WriteLine();
}
int FindElements(int[] arr)
{
    int count = 0;
    for(int i = 0; i < arr.Length; i++)
    {
        if(arr[i] % 2 == 1)
        {
            count++;
        }
    }
    return count;
}
int[] myarr = ArrayCreation(100);
PrintArray(myarr);
int count = FindElements(myarr);
Console.WriteLine(count);
Console.WriteLine($"Количество чётных чисел в массиве: {count}");

/ Задача 38. Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива. [3 7 22 2 78] -> 76
double[] arrayRealNumbers = new double[10];
  for (int i = 0; i < arrayRealNumbers.Length; i++ )
  {
    arrayRealNumbers[i] = new Random().Next(1, 10);
    Console.Write(arrayRealNumbers[i] + " ");
  }

double maxNumber = arrayRealNumbers[0];
double minNumber = arrayRealNumbers[0];

  for (int i = 1; i < arrayRealNumbers.Length; i++)
  {
    if (maxNumber < arrayRealNumbers[i])
    {
      maxNumber = arrayRealNumbers[i];
    }
        if (minNumber > arrayRealNumbers[i])
    {
      minNumber = arrayRealNumbers[i];
    }
  }

  double difference = maxNumber - minNumber;

  Console.WriteLine($"\nразница между между максимальным ({maxNumber}) и минимальным({minNumber}) элементами: {difference}");