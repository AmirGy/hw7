/* Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4 
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

int[,] CreateFillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 11);
    return array;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i, j],3}\t");
        }
        Console.WriteLine();
    }
}

void AverageCols(int[,] table, int cols, int rows)
{
    double sum = 0;
    double average = 0;
    double round;
    for (int i = 0; i < cols; i++)
    {
        for (int j = 0; j < rows; j++)
            sum += table[j, i];
        average = sum / cols;
        round = Math.Round(average, 2);
        Console.Write($"Среднее = {round,3}\t");
        sum = 0;
    }
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] table = CreateFillArray(rows, cols);
PrintArray(table);
AverageCols(table, cols, rows);
