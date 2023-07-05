// See https://aka.ms/new-console-template for more information

using System;
using static System.Console;

Clear();
WriteLine();
int[,] arrr = new int[8, 8];
FilArray(arrr);
PrintArray(arrr);
WriteLine($"Номер строки с наименьшей суммой: {DoArray(arrr)}");
WriteLine();

void FilArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) ar[i, j] = new Random().Next(1, 99);
    }
}


void PrintArray(int[,] ar)
{
    for (int i = 0; i < ar.GetLength(0); i++)
    {
        for (int j = 0; j < ar.GetLength(1); j++) Write(ar[i, j] + " ");
        WriteLine();
    }
    WriteLine();
}


int DoArray(int[,] ar)
{
    int[,] ar2 = new int[ar.GetLength(0), 1];

    for (int i = 0; i < ar.GetLength(0); i++)
    {
        int sum = 0;

        for (int j = 0; j < ar.GetLength(1); j++)
        {
            sum = sum + ar[i, j];
        }
        ar2[i, 0] = sum;
        WriteLine($"Сумма элементов {i+1}-й строки равна: {ar2[i, 0]}");
    }
    int res = ar2[0, 0];
    int StrIn = 1;
    for (int i = 1; i < ar.GetLength(0); i++)
    {
        if (ar2[i, 0] < res)
        {
            res = ar2[i, 0];
            StrIn = i + 1;
        }

    }

    return StrIn;
}