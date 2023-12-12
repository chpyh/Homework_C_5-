//Задайте двумерный массив. Напишите программу, которая поменяет 
//местами первую и последнюю строку массива.

void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(1, 21);
        }
    }
}
void PrintMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void MoveLinesInMatrix(int[,] matrix)
{
    int temporaryElement = 0;
    int length = matrix.GetLength(0) - 1;
    //for (int i = 0; i < matrix.GetLength(0); i++)
    //{ - тут внешний цикл не нужен, 
    //во-первых, он лишний, а в-вторых, в случае, если будет 
    //четное количество строк, все останется на своих местах.
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                temporaryElement = matrix[0, j];
                matrix[0, j] = matrix[length, j];
                matrix[length, j] = temporaryElement;
            }

        }
    //}
int i = new Random().Next(1, 11);
int j = new Random().Next(1, 11);
int[,] matrix = new int[i, j];
InputMatrix(matrix);
Console.WriteLine("Массив до перемены строк местами:");
PrintMatrix(matrix);
Console.WriteLine();
Console.WriteLine("Массив после перемены первой и последней строк местами:");
MoveLinesInMatrix(matrix);
PrintMatrix(matrix);
