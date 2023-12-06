//Задача 1: Напишите программу, которая на вход принимает позиции 
//элемента в двумерном массиве, и возвращает значение этого элемента 
//или же указание, что такого элемента нет.

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
void PrintMatrix(int[,] matrix){
     for(int i = 0; i < matrix.GetLength(0); i++)
     {
         for (int j = 0; j < matrix.GetLength(1); j++)
         {
             Console.Write($"{matrix[i, j]} \t");
         }
         Console.WriteLine();
     }
 }
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

