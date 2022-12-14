/*                          Домашнее задание к семинару 6 С#
задача 2 HARD необязательная. 
Сгенерировать массив случайных целых чисел размерностью m*n (размерность вводим с клавиатуры).
Вывести на экран красивенько таблицей. 
Найти минимальное число и его индекс, найти максимальное число и его индекс. 
Вывести эту информацию на экран.                */

void FillArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            matr[i, j] = new Random().Next(-99999, 99999);
        }
    }
}

void PrintArray(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
           Console.Write(matr[i, j] + "\t");
        }
        Console.Write(Environment.NewLine + Environment.NewLine);
    }
}

void FindMinNum(int[,] matr)
{
    int MinNum = 0;
    int row = 0;
    int column = 0;
    int i = 0;
    int j = 0;
    for (i = 0; i < matr.GetLength(0); i++)
    {
        for (j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] < MinNum)
            {
                MinNum = matr[i, j];
                row = i;
                column = j;
            }
        }
    }
    Console.WriteLine($"Минимальное число: {MinNum}");
    Console.WriteLine($"Индекс: [{row}, {column}]");
}

void FindMaxNum(int[,] matr)
{
    int MaxNum = 0;
    int row = 0;
    int column = 0;
    int i = 0;
    int j = 0;
    for (i = 0; i < matr.GetLength(0); i++)
    {
        for (j = 0; j < matr.GetLength(1); j++)
        {
            if (matr[i, j] > MaxNum)
            {
                MaxNum = matr[i, j];
                row = i;
                column = j;
            }                
        }
    }
    Console.WriteLine($"Максимальное число: {MaxNum}");
    Console.WriteLine($"Индекс: [{row}, {column}]");
}

Console.WriteLine("Введите количество строк массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите количество столбцов массива: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine();
int[,] matrix = new int[m, n];
FillArray(matrix);
PrintArray(matrix);
Console.WriteLine();
FindMinNum(matrix);
Console.WriteLine();
FindMaxNum(matrix);