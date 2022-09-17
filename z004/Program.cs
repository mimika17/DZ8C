// Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
// Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
Console.WriteLine("Введите размерность трехмерного массива");
Console.WriteLine("Введите X ");
int x = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Y ");
int y = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите Z ");
int z = Convert.ToInt32(Console.ReadLine());
int[] linemas = NoRepeatArray(x, y, z);
int[,,] Array3D = FillthreeArray(linemas, x, y, z);
PrintThreeArray(Array3D);
int[] NoRepeatArray(int a, int b, int c)
{
    int d = a * b * c;
    int[] array = new int[d];
    for (int i = 0; i < d; i++)
    {
        array[i] = new Random().Next(10, 100);
        int number = array[i];
        if (i >= 1)
            for (int j = 0; j < i; j++)
            {
                while (array[i] == array[j])
                {
                    array[i] = new Random().Next(10, 100);
                    j = 0;
                    number = array[i];
                }
                number = array[i];
            }
    }

    return array;
}

int[,,] FillthreeArray(int[] array, int x, int y, int z)
{
    int[,,] threearray = new int[x, y, z];
    int count = 0;
    for (int i = 0; i < threearray.GetLength(0); i++)
    {
        for (int j = 0; j < threearray.GetLength(1); j++)
        {
            for (int k = 0; k < threearray.GetLength(2); k++)
            {

                threearray[i, j, k] = array[count];
                count++;
            }
        }
    }
    return threearray;

}

void PrintThreeArray(int[,,] table)
{
    for (int i = 0; i < table.GetLength(0); i++)
    {
        for (int j = 0; j < table.GetLength(1); j++)
        {
            for (int k = 0; k < table.GetLength(2); k++)
            {
            Console.Write($"{table[i, j,k]} ({i},{j},{k})\t");
            }
        Console.WriteLine();
        }
       
    }
}