// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07
//эту честно списала))
int n = 4;
int[,] spiral = new int[n, n];
int num = 1;
int i = 0;
int j = 0;
while (num <= n * n)
{
    spiral[i, j] = num;
    if (i <= j + 1 && i + j < n - 1)
        ++j;
    else if (i < j && i + j >= n - 1)
        ++i;
    else if (i >= j && i + j > n - 1)
        --j;
    else
        --i;
    ++num;
}
PrintArray(spiral);
void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            if (table[i, j] < 10) Console.Write("0" + table[i, j] + " ");
            else Console.Write(table[i, j] + " ");

        }
        Console.WriteLine();
    }
}
