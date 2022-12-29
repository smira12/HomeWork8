/*Задача 60. ...Сформируйте трёхмерный массив из неповторяющихся двузначных чисел.
Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
Массив размером 2 x 2 x 2
66(0,0,0) 25(0,1,0)
34(1,0,0) 41(1,1,0)
27(0,0,1) 90(0,1,1)
26(1,0,1) 55(1,1,1)
*/

int GetNumber(string message)
{
    int result;

    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result))
        {
            break;
        }
        else
        {
            Console.WriteLine("Ввели не число!");
        }
    }
    return result;
}

int[,,] Random3dArray(int field, int rows, int columns)
{
    int[,,] newArray = new int[field, rows, columns];
    Random rnd = new Random();
    for (int i = 0; i < field; i++)
    {
        for (int j = 0; j < rows; j++)

        {
            for (int k = 0; k < columns; k++)
            {
                newArray[i, j, k] = rnd.Next(1, 100);
            }
        }
    }
    return newArray;
}

void Print3dArray(int[,,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                Console.Write($"{array[i, j, k]}[{i},{j},{k}] ");
            }
            Console.WriteLine();
        }
    }
}

void FillArray(int[,,] array)
{
    int count = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int k = 0; k < array.GetLength(2); k++)
            {
                array[i, j, k] += count;
            }
        }
    }
}

int i = GetNumber("Input number of field: ");
int j = GetNumber("Input number of rows: ");
int k = GetNumber("Input number of columns: ");
int[,,] array = Random3dArray(i, j, k);
FillArray(array);
Print3dArray(array);