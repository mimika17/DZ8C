// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить
// строку с наименьшей суммой элементов.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей 
// суммой элементов: 1 строка

void PrintArray(int[,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            Console.Write(table[i, j] + "\t");
        }
        Console.WriteLine();
    }
}
int[,] FillArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++) array[i, j] = new Random().Next(1, 10);
    }
    return array;
}
Console.WriteLine("Введите количество строк двумерного массива ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  двумерного массива ");
int n = Convert.ToInt32(Console.ReadLine());
if (m == n) Console.WriteLine("Массив прямоугольный количество строк и столбцов должны быть не равны ");
else
{
    int[,] mas = FillArray(m, n);
    PrintArray(mas);
    int[] Sum = SumRows(mas);
    Console.WriteLine($"Номер строки с наименьшей суммой элементов: {MinSum(Sum) + 1} ");
}
int[] SumRows(int[,] array)
{
    int[] sumrows = new int[array.GetLength(0)];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
            if (j == array.GetLength(1) - 1) sumrows[i] = sum;
        }
    }
    return sumrows;
}
int MinSum(int[] array)
{
    int pos = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < array[pos]) pos = i;
    }
    return pos;
}


