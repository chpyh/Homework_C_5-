# Homework_C_5-
Решение задач с 1 по 4 в отдельных папках. в этом файле можно посмотреть полностью. 
Вторая задача работапет, но не каждый раз: 5 раз работает, а на 6-1 оставляет все на своих местах. 
Пока не могу понять, почему. 
В четвертой пошел затык - решена тсовсем частично. Думаю, потому что пытаюсь решить математически, хотя наверняка есть готовые функции.
## Решения задач:
### Общая часть для всех:
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

### Задача 1:
int i = new Random().Next(1, 11);
int j = new Random().Next(1, 11);
int[,] matrix = new int[i, j];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine("Введите номер строки:");
int line = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите номер столбца:");
int column = int.Parse(Console.ReadLine()!);
if(line < matrix.GetLength(0)&& column < matrix.GetLength(1))
{
    Console.Write($"{matrix[line, column]}");
}
else 
{
    Console.Write("Параметры отсутствуют");
}

### Задача 2:
void MoveLinesInMatrix(int[,] matrix)
{
    int temporaryElement = 0;
    int length = matrix.GetLength(0) - 1;
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
                temporaryElement = matrix[0, j];
                matrix[0, j] = matrix[length, j];
                matrix[length, j] = temporaryElement;
            }

        }
    }
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

### Задача 3:
 int [] SummInMatrixLine(int[,] matrix)
 {
    int[] sum_array = new int[matrix.GetLength(0)];
    int index = 0;
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            sum += matrix[i, j];
        }
        sum_array[index] = sum;
        Console.WriteLine($"{sum_array[index]}");
        index++;
    }
    return sum_array;
}
void FindMin (int[] array)
{
    int Min = array[0]; 
    int MinLine = 0;
    for(int index = 0; index < array.Length; index++)
    {
        if(array[index] < Min)
        {
            Min = array[index];
            MinLine = index;
        }
    }
    Console.WriteLine($"Строка с наименьшей суммой элементов: { MinLine}");

}
int i = new Random().Next(1, 11);
int j = new Random().Next(1, 11);
int[,] matrix = new int[i, j];
InputMatrix(matrix);
PrintMatrix(matrix);
Console.WriteLine(" Суммы елементов в строках: "); 
int[] array = SummInMatrixLine(matrix);
FindMin(array);

### Задача 4 - которая толком не работает:
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

void InputNewMatrix(int[,] matrix, int a, int b)
{
    int x = matrix.GetLength(0) - 1;
    int y = matrix.GetLength(1) - 1;
    int[,] tabl = new int[x, y];
    int row = 0;
    int col = 0;
    for (int i = 0; i < matrix.GetLength(0);  i++)
    {
        if (i != a)
        {
            for (int j = 0; j < matrix.GetLength(1);  j++)
            {
                if (j != b)
                {
                    tabl[row, col] = matrix[i, j];
                    Console.Write($"{tabl[row, col]} \t");
                    col++;
                }
            }
        }
        row++;
    }
    Console.WriteLine();
}
int i = new Random().Next(1, 11);
int j = new Random().Next(3, 11);
int[,] matrix = new int[i, j];
InputMatrix(matrix);
Console.WriteLine("Исходный двумерный массив:");
PrintMatrix(matrix);
int MinRow = FindMinRow(matrix);
int MinCol = FindMinCol(matrix);
Console.WriteLine("Массив после удаления строки и столбца с минимальным элементом:");
InputNewMatrix(matrix, MinRow, MinCol);



