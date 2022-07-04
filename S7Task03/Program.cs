// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

using System;
using static System.Console;

Clear();

Write("Введите размер массива через пробел: ");
string[] sizeS = ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
int rows = int.Parse(sizeS[0]);
int columns = int.Parse(sizeS[1]);

int[,] ar = GetRandomArray(rows, columns);
PrintArray(ar);
PrintAveSumArray(ar);

void PrintAveSumArray(int[,] array)
{
    double result = 0;
    double[] answer = new double[array.GetLength(1)];
    int index = 0;

    for (int i = 0; i < array.GetLength(1); i++)
    {
        result = 0;
        for (int j = 0; j < array.GetLength(0); j++)
        {

            result += ar[j, i];

        }
        result = Math.Round(result / array.GetLength(0), 1);
        answer[index] = result;
        index++;
    }
    WriteLine($"Среднее арифметическое каждого столбца: [{String.Join("; ", answer)}]");
}


int[,] GetRandomArray(int row, int columm)
{
    int[,] rezult = new int[row, columm];

    for (int i = 0; i < rezult.GetLength(0); i++)
    {
        for (int j = 0; j < rezult.GetLength(1); j++)
        {

            rezult[i, j] = new Random().Next(1, 10);

        }
    }
    return rezult;
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
    WriteLine();
}

