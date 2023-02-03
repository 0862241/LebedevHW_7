// Task1. Specify a two-dimensional array of size m×n filled with random real numbers.
/*
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
*/

// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.

Console.Write("Enter the number of rows:  ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a minimum value: ");
int minValue = Convert.ToInt32(Console.ReadLine());
Console.Write("Input a maximum value: ");
int maxValue = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
CrateArrayRandom(numbers);
ShowArray(numbers);
void CrateArrayRandom(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(minValue, maxValue));
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
Console.Write("Input the position of number in the row: ");
int posRow = Convert.ToInt32(Console.ReadLine()) - 1;
Console.Write("Input the position of number in the column: ");
int posColumn = Convert.ToInt32(Console.ReadLine()) - 1;
if (posRow < 0 || posRow >= rows || posColumn < 0 || posColumn >= columns)
{
    Console.WriteLine("There is no element with the specified indexes in this array");
}
else
{
    Console.WriteLine("The requested array element is: " + numbers[posRow, posColumn]);
}


// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Console.Write("Enter the number of strings:  ");
int rows  = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the number of columns: ");
int columns = Convert.ToInt32(Console.ReadLine());
double[,] numbers = new double[rows, columns];
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

int[,] array = new int[rows, columns];
Random random = new Random();
for (int i = 0; i < rows; i++)
{
    for (int j = 0; j < columns; j++)
    {
        array[i, j] = random.Next(0, 100);
    }
}
for (int j = 0; j < columns; j++)
{
    double sum = 0;
    for (int i = 0; i < rows; i++)
    {
        sum += array[i, j];
    }
    double avg = sum / rows;
    Console.WriteLine("Arithmetic mean of column elements " + (j + 1) + ": " + avg);
}
*/