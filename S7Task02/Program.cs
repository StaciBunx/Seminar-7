// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//и возвращает значение этого элемента или же указание, что такого элемента нет.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

// 17 -> такого числа в массиве нет

using System;
using static System.Console;
Clear();


int[,] ar = GetRandomArray(3, 4);
PrintArray(ar);
WriteLine();

WriteLine("Введите позицию элемента через пробел: ");
string[] position = ReadLine().Split(' ', StringSplitOptions.RemoveEmptyEntries);
int row = int.Parse(position[0]);
int column = int.Parse(position[1]);

GetValueByIndex(ar, row, column);

void GetValueByIndex(int[,] arr, int line, int col)
{
    if (line < arr.GetLength(0) & col < arr.GetLength(1)) WriteLine($"{arr[line, col]}");
    else WriteLine("Такого числа в массиве нет");
}


int[,] GetRandomArray(int row, int column)
{
    int[,] result = new int[row, column];
    for (int i = 0; i < result.GetLength(0); i++)
    {
        for (int j = 0; j < result.GetLength(1); j++)
        {
            result[i, j] = new Random().Next(0, 5);
        }
    }
    return result;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {


        for (int j = 0; j < array.GetLength(1); j++)
        {
            Write($"{array[i, j]} ");
        }
        WriteLine();
    }

}