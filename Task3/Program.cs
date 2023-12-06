//Задайте прямоугольный двумерный массив. 
//Напишите программу, которая будет находить строку с наименьшей суммой элементов.
// Строчки нумеруем с 0.

void InputMatrix(int[,] matrix)
{
    for(int i = 0; i < matrix.GetLength(0); i++)
    {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             matrix[i, j] = new Random().Next(1, 21);
         }
     }
 }
void PrintMatrix(int[,] matrix)
{
     for(int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             Console.Write($"{matrix[i, j]} \t");
         }
         Console.WriteLine();
     }
     Console.WriteLine();
 }
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
