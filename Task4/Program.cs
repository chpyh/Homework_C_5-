// (не обязательная): Задайте двумерный массив из целых чисел. 
//Напишите программу, которая удалит строку и столбец, 
//на пересечении которых расположен наименьший элемент массива. 
//Под удалением понимается создание нового двумерного массива без строки и столбца.
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
int FindMinRow(int[,] matrix)
{
    int Min = matrix[0, 0];
    int RowMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < Min)
            {
                Min = matrix[i, j];
                RowMin = i;
            }
        }
    }

    return RowMin;
}

int FindMinCol(int[,] matrix)
{
    int Min = matrix[0, 0];
    int ColMin = 0;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (matrix[i, j] < Min)
            {
                Min = matrix[i, j];
                ColMin = j;
            }
        }
    }
    return ColMin;
}

void InputNewMatrix(int[,] matrix; int a; int b){
int x = matrix.GetLength(0) - 2;
int y = matrix.GetLength(1) - 2;
int[,] tabl = new int[x, y];
int row = 0;
int cow = 0;
for (int i = 0; i < matrix.GetLength(0); i++)
{
    if (i != a)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            if (j != b)
            {
                table[row, cow] = matrix[i, j];
                Console.Write($"{tabl[row, cow]} \t");
                cow++;
            }
        }
    }
    row++;
}
Console.WriteLine();
};
int i = new Random().Next(1, 11);
int j = new Random().Next(1, 11);
int[,] matrix = new int[i, j];
InputMatrix(matrix);
Console.WriteLine("Исходный двумерный массив:");
PrintMatrix(matrix);
int MinRow = FindMinRow(matrix);
Console.WriteLine(MinRow);
int MinCol = FindMinCol(matrix);
Console.WriteLine(MinCol);
Console.WriteLine("Массив после удаления строки и столбца с минимальным элементом:");
InputNewMatrix(matrix, MinRow, MinCol);

