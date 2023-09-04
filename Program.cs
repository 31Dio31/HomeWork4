/* Задачи находятся в ветках:
Задача 1 - ветка main;
Задача 2 - ветка vetka2;
Задача 3 - ветка vetka3;

Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
Напишите программу, которая покажет количество чётных чисел в массиве */
var array = GenerateArray(5);
PrintArray(array);
Console.WriteLine( );
Console.WriteLine($"количество четных чисел = {SumaNumberAdd (array)}");

int SumaNumberAdd(int [] array)
{
	int sum=0;
    for (int i = 0; i < array.Length; i++)
	if  (array[i]%2==0)
    {
      sum = sum + 1;
    }   
return sum;
}


int[] GenerateArray(int length) 
{
    int[] result = new int[length];
    for (int i = 0; i < result.Length; i++)
    {
        result[i] = new Random().Next(-10, 10);
    }
    return result;
}


void PrintArray(int[] array) 
{
    foreach (int i in array) 
    {
        Console.Write($"{i} ");
    }
}
