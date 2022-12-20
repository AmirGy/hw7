/* Напишите программу, которая на вход принимает значение элемента в двумерном массиве,
и возвращает позицию этого элемента или же указание, что такого элемента нет.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
17 -> такого числа в массиве нет */


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

void FindNum(int[,] table, int num)
{
    bool x = false;
    for (int j = 0; j < table.GetLength(0); j++)
    {
        for (int i = 0; i < table.GetLength(1); i++)
            if (table[j, i] == num)
            {
                Console.Write($"Такой элемент есть - [{j};{i}]");
                Console.WriteLine();
                x = true;
            }
    }
    if (x == false) Console.Write($"Такого элемента нет");
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] table = CreateFillArray(rows, cols);
PrintArray(table);
Console.Write("Введите нужный элемент: ");
int num = Convert.ToInt32(Console.ReadLine());
FindNum(table, num);





