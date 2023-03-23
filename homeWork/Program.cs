// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

// m = 3, n = 4.

// 0,5 7 -2 -0,2

// 1 -3,3 8 -9,9

// 8 7,8 -7,1 9

int Prompt(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}



void FillArrayRealNumbers(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = Convert.ToDouble(new Random().Next(-100, 100)) / 10;
        }
    }
}

void PrintArray(double[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        
        Console.WriteLine();
    }
}

// int m = Prompt("Введите колличество строк:");
// int n = Prompt("Введите колличество столбцов:");
// double[,] array = new double[m, n];
// FillArrayRealNumbers(array);
// PrintArray(array);

// ========================================================================


// Задача 50. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве,
//  и возвращает значение этого элемента или же указание, что такого элемента нет.

// Например, задан массив:

// 1 4 7 2

// 5 9 2 3

// 8 4 2 4

// 17 -> такого числа в массиве нет

void FillArrayNumbers(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
        {        
            for (int j = 0; j < array.GetLength(1); j++)
            {
                array [i,j] = new Random().Next(0, 100);
            }   
        }
}
void PrintArrayIndex(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + "\t");
        }   

        Console.WriteLine(" "); 
    }
}


// int m = Prompt("Введите индекс строки:");
// int n = Prompt("Введите индекс столбца:");
// int [,] numbers = new int [10,10];
// FillArrayNumbers(numbers);
// PrintArrayIndex(numbers);
// if (n > numbers.GetLength(0) || m > numbers.GetLength(1))
// {
//     Console.WriteLine("такого элемента нет");
// }
// else
// {
//     Console.WriteLine($"Значение элемента {n} строки и {m} столбца равно: {numbers[n-1,m-1]}");
// }


 


// ========================================================================


// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void PrintArraySumCollumns(int[,] array)
{

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + "\t");
        }
        Console.WriteLine("");
    }
}
int m = Prompt("Введите колличество строк:");
int n = Prompt("Введите колличество столбцов:");

int[,] numbers = new int[n, m];
FillArrayNumbers(numbers);


for (int j = 0; j < numbers.GetLength(1); j++)
{
    int avarage = 0;
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        avarage = (avarage + numbers[i, j]);
    }
    avarage = avarage / n;
    Console.Write(avarage + "\t");
}
Console.WriteLine();
Console.WriteLine();
PrintArraySumCollumns(numbers);
