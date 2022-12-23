/*Задача 34: Задайте массив заполненный случайными положительными 
трёхзначными числами. Напишите программу, которая покажет количество чётных чисел 
в массиве.

[345, 897, 568, 234] -> 2
*/
/*
int[] CreateRandomArray (int size,int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i=0;i<size;i++)
    {
        myArray[i] = new Random().Next(minValue,maxValue+1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

void FindEvenNumber (int[] array)
{
int countEven = 0;
    for (int i = 0; i < array.Length; i++)
    {
    if (array[i] % 2 == 0) countEven += 1;
    }
    Console.WriteLine($"Количество четных чисел в массиве = {countEven}");
}

Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
int min=100;
int max=1000;
int[] newArray = CreateRandomArray (lenght,min,max);
ShowArray(newArray);
FindEvenNumber(newArray);
*/
/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.

[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
*/
/*
int[] CreateRandomArray (int size,int minValue, int maxValue)
{
    int[] myArray = new int[size];
    for(int i=0;i<size;i++)
    {
        myArray[i] = new Random().Next(minValue,maxValue+1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

int SumNotEvenIndex (int[] array)
{
    int sum = 0;
    for(int i = 1; i < array.Length; i=i+2)
    {
        sum += array[i];
    }
    return sum;
}

Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght,min,max);
ShowArray(newArray);
int result = SumNotEvenIndex(newArray);
Console.WriteLine ($"Сумма элементов, стоящих на нечётных позициях = {result}");
*/
/*
Задача 38: Задайте массив вещественных чисел. 
Найдите разницу между максимальным и минимальным элементов массива.

[3 7 22 2 78] -> 76
*/
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int [] myArray = new int[size];
    for(int i=0;i<size;i++)
    {
        myArray[i] = new Random().Next(minValue,maxValue+1);
    }
    return myArray;
}

void ShowArray (int[] array)
{
    Console.WriteLine("Полученный массив ->:");
    for(int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i]+" ");
    }
    Console.WriteLine();
}

int FindMaxMinDiff (int[] array)
{
    int i=0;
    int Max = array[i];
    int Min = array[i];
    for (i=1; i < array.Length; i++)
    {
        if (array[i] > Max) 
        {
            Max = array[i];
        }
        if (array[i] < Min)
        {
            Min = array[i];
        }
    }
    Console.WriteLine ($"Max= {Max}");
    Console.WriteLine ($"Min= {Min}");
    int result = Max - Min;
    return result;
}

Console.WriteLine("Введите размер массива:");
int lenght = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите минимально возможное значение элемента массива:");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите максимально возможное значение элемента массива:");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(lenght,min,max);
ShowArray(newArray);
int res = FindMaxMinDiff(newArray);
Console.WriteLine ($"Разница между минимальным и макксимальным элементом массива = {res}");
