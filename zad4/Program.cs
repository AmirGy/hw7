/*Задайте двумерный массив из целых чисел. 
Количество строк и столбцов задается с клавиатуры. Отсортировать элементы по возрастанию слева направо и сверху вниз.
Например, задан массив:
1 4 7 2
5 9 10 3
После сортировки
1 2 3 4
5 7 9 10    */

int[,] CreateFillArray(int rows, int cols)
{
    int[,] array = new int[rows, cols];
    for (int i = 0; i < array.GetLength(0); i++)
        for (int j = 0; j < array.GetLength(1); j++)
            array[i, j] = new Random().Next(-10, 11);
    return array;
}

int[,] SortArray(int[,] mas, int rows, int cols)
{
    int temp = 0;
    for (int i = rows * cols - 1; i > 0; i--)
        for (int j = 0; j < i; j++)
            if (mas[j / cols, j % cols] > mas[i / cols, i % cols])
            {
                temp = mas[j / cols, j % cols];
                mas[j / cols, j % cols] = mas[i / cols, i % cols];
                mas[i / cols, i % cols] = temp;
            }
    return mas;
}

void PrintArray(int[,] mas)
{
    for (int i = 0; i < mas.GetLength(0); i++)
    {
        for (int j = 0; j < mas.GetLength(1); j++)
        {
            Console.Write($"{mas[i, j],3}\t");
        }
        Console.WriteLine();
    }
}

Console.Write("Введите количество строк в массиве: ");
int rows = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов в массиве: ");
int cols = Convert.ToInt32(Console.ReadLine());

int[,] mas = CreateFillArray(rows, cols);
Console.WriteLine("Изначальный массив: ");
PrintArray(mas);
Console.WriteLine("Исправленный массив: ");
SortArray(mas, rows, cols);
PrintArray(mas);




// int[,] array = { { 1, 4, 7, 2 }, { 5, 9, 10, 3 } };

// int temp;
// int size = array.GetLength(1);
// for (int k = 0; k < size; k++)
//     for (int m = 0; m < size; m++)
//         for (int i = 0; i < size; i++)
//             for (int j = 0; j < size; j++)
//                 if (array[i, j] > array[i + 1, 0])
//                 {
//                     temp = array[i, j];
//                     array[i, j] = array[i + 1, 0];
//                     array[i + 1, 0] = temp;
//                 }
//                 else if (array[i, j] > array[0, j + 1])
//                 {
//                     temp = array[i, j];
//                     array[i, j] = array[0, j + 1];
//                     array[0, j + 1] = temp;
//                 }