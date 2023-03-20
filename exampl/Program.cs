

int[,] CreateOutputArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(1, 11);
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    return array;
}
// CreateOutputArray(3, 4);

// =========================================================================================

// Задача 46: Задайте двумерный массив размером m×n, заполненный случайными целыми числами.
// m = 3, n = 4.
// 1 4 8 19
// 5 -2 33 -2
// 77 3 8 1


int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



int[,] MNArray(int m, int n)
{
    int[,] array = new int[m, n];
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = i + j;
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }

    return array;
}
int m = Prompt("Введите число строк:");
int n = Prompt("Введите количество столбцов:");
Console.WriteLine();
// MNArray(m, n);

// =======================================================================================

// Задача 49: Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.
// Например, изначально массив
// выглядел вот так:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4

int[,] MultIndex(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i % 2 == 0 && j % 2 == 0)
            {
                array[i, j] *= array[i, j];
            }
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine();
    }
    return array;
}

// int[,] num = CreateOutputArray(m, n);
// Console.WriteLine();
// MultIndex(num);





// =======================================================================================

// Задача 51: Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Сумма элементов главной диагонали: 1+9+2 = 12

int SumElemrnts(int[,] array)
{
    int sum = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (i == j)
                sum += array[i, j];
        }
    }
    return sum;
}


// int[,] num = CreateOutputArray(m, n);
// Console.WriteLine(SumElemrnts(num));

int SumElemrnts2(int[,] array)
{
int sum = 0;
for (int i = 0, j = 0; i < array.GetLength(0) && j < array.GetLength(1); i++, j++)
        sum += array[i, j];

return sum;
}
Console.WriteLine();
Console.WriteLine(SumElemrnts2(CreateOutputArray(m, n)));
