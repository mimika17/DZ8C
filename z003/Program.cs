// Задача 58: Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18
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
int[,] MultiplyMatrix(int[,] matrA, int[,] matrB)
{
    int[,] masAB = new int[matrA.GetLength(0), matrB.GetLength(1)];
    for (int i = 0; i < masAB.GetLength(0); i++)
    {
        for (int j = 0; j < masAB.GetLength(1); j++)
        {
            int sum = 0;
            for (int k = 0; k < matrA.GetLength(1); k++)
            {
                sum = sum + matrA[i, k] * matrB[k, j];
            }
            masAB[i, j] = sum;
        }
    }
    return masAB;
}
Console.WriteLine("Введите количество строк в 1 матрице ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  в 1 матрице ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество строк в 2 матрице ");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов  в 2 матрице ");
int b = Convert.ToInt32(Console.ReadLine());
if (n == a)
{
    int[,] masA = FillArray(m, n);
    int[,] masB = FillArray(a, b);
    Console.WriteLine("Первая матрица");
    PrintArray(masA);
    Console.WriteLine("Вторая матрица");
    PrintArray(masB);
    int[,] matrixAB = MultiplyMatrix(masA, masB);
    Console.WriteLine("Произведение матриц");
    PrintArray(matrixAB);
}
else Console.WriteLine("Матрицу A можно умножить на матрицу B только в том случае,"
                      + " если число столбцов матрицы A равняется числу строк матрицы B."
                      + " Матрицы, для которых данное условие не выполняется, умножать нельзя.");
