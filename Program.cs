// Task1. Specify a two-dimensional array of size m×n filled with random real numbers.

Console.Write("Input a number of rows: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());

double[,] numbers = new double[rows, columns];

Crate2dArrayRandomNumbers(numbers);
ShowArray(numbers);
void Crate2dArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue + 1));
        }
    }
}
void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
        
    }
    Console.WriteLine();
}


// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
/*
Console.Write("Enter the number of strings:  ");
int linesVol = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
CrateArrayRandomNumbers(numbers);
ShowArray(numbers);
void CrateArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
        }
    }
}
void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}
Console.Write("Enter the item position number in the line: ");
int pos1 = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Enter the item position number in the column: ");
int pos2 = Convert.ToInt32(Console.ReadLine()) - 1;
if (pos1 < 0 || pos1 >= linesVol || pos2 < 0 || pos2 >= columnsVol)
{
    Console.WriteLine("There is no such element in the array.");
}
else
{
    Console.WriteLine("Element value: " + numbers[pos1, pos2]);
}
*/

// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.Write("Enter the number of strings:  ");
int linesVol  = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columnsVol = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[linesVol, columnsVol];
CrateArrayRandomNumbers(numbers);
ShowArray(numbers);

void CrateArrayRandomNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100));
        }
    }
}

void ShowArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        Console.Write("[");
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.Write("]");
        Console.WriteLine("");
    }
}

int[,] array = new int[linesVol, columnsVol];
Random random = new Random();
for (int i = 0; i < linesVol; i++)
{
    for (int j = 0; j < columnsVol; j++)
    {
        array[i, j] = random.Next(0, 100);
    }
}
for (int j = 0; j < columnsVol; j++)
{
    double sum = 0;
    for (int i = 0; i < linesVol; i++)
    {
        sum += array[i, j];
    }
    double avg = sum / linesVol;
    Console.WriteLine("Arithmetic mean of column elements " + (j + 1) + ": " + avg);
}
*/