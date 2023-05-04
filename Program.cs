// Задача 1. --------------------------------------------------------------------------------------------------------------
// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
// m = 3, n = 4.
// 0,5 7 -2 -0,2
// 1 -3,3 8 -9,9
// 8 7,8 -7,1 9

//------functions------
double[,] CreateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    double random;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            random = Math.Round((new Random().Next(-10, 10) + new Random().NextDouble() * 10), 1);
            array[i, j] = random;
        }
    return array;
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

// ------main------
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] arr = CreateArray(rows, columns);
ShowArray(arr);

// Задача 2. --------------------------------------------------------------------------------------------------------------
// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого 
// элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 1 7 -> числа с такими индексами в массиве нет

//------functions------
int[,] CreateArray(int rows, int columns)
{
    int[,] array = new int[rows, columns];
    int random;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            random = new Random().Next(-10, 10);
            array[i, j] = random;
        }
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowElementArray(int[,] array, int indexRow, int indexColumn)
{
    if (indexRow < 0 || indexRow >= array.GetLength(0) || indexColumn < 0 || indexColumn >= array.GetLength(1))
        Console.WriteLine($"Элемента с индексами {indexRow}, {indexColumn} в массиве нет");
    else
        Console.WriteLine("Элемент равен :" + array[indexRow, indexColumn]);
}

//------main------
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

int[,] arr = CreateArray(rows, columns);
ShowArray(arr);

Console.Write("Введите номер строки в двумерном массиве: ");
int indexRow = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите номер столбца в двумерном массиве: ");
int indexColumn = Convert.ToInt32(Console.ReadLine());

ShowElementArray(arr, indexRow, indexColumn);

// Задача 3. --------------------------------------------------------------------------------------------------------------
// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

// ------functions------
double[,] CreateArray(int rows, int columns)
{
    double[,] array = new double[rows, columns];
    int random;
    for (int i = 0; i < rows; i++)
        for (int j = 0; j < columns; j++)
        {
            random = new Random().Next(0, 10);
            array[i, j] = random;
        }
    return array;
}

void ShowArray2d(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");
        Console.WriteLine();
    }
    Console.WriteLine();
}

void ShowArray(double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
}

double[] GetAverageColumn(double[,] array)
{
    int count = array.GetLength(0);
    double sum = 0;
    double[] AverageColumnArray = new double[array.GetLength(1)];
    for (int j = 0; j < array.GetLength(1); j++)
    {
        sum = 0;
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
        AverageColumnArray[j] = Math.Round(sum / count, 2);
    }
    return AverageColumnArray;
}

// //------main------
Console.Write("Введите количество строк: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов: ");
int columns = Convert.ToInt32(Console.ReadLine());

double[,] arr = CreateArray(rows, columns);
ShowArray2d(arr);
ShowArray(GetAverageColumn(arr));