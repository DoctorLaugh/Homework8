﻿using System;
using static System.Console;
int[,] TrianglePasqual(int rows)
{
    int[,] TriPas = new int[rows, rows + (rows - 1)];
    for (int i = 0; i < rows; i++)
    {
        for (int j = 0; j <= i; j++)
        {
            TriPas[i, (rows - 1 - i + (j * 2))] = factorial(i) / (factorial(j) * factorial(i - j));
        }
    }
    return TriPas;
}
int factorial(int n)
{
    int x = 1;
    for (int i = 1; i <= n; i++)
    {
        x *= i;
    }
    return x;
}
Clear();
Write("Введите нужное количество строк треугольника Паскаля: ");
int rows = int.Parse(ReadLine());
int[,] trianPasq = TrianglePasqual(rows);
for (int i = 0; i < trianPasq.GetLength(0); i++)
{
    for (int j = 0; j < trianPasq.GetLength(1); j++)
    {
        if (trianPasq[i, j] == 0)
        {
            Write(" ");
        }
        else
        {
            Write(trianPasq[i, j]);
        }
    }
    WriteLine();
}