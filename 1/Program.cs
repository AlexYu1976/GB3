// Задача 46: Задайте двумерный массив размером m×n, 
//заполненный случайными вещественными  числами.
// m = 3, n = 4.


Console.Write("Введите количество строк m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите количество столбцов n: ");
int n = Convert.ToInt32(Console.ReadLine());

double[,] array = new double[m,n];

for(int i=0; i < m; i++)
{
   for(int j=0; j<n; j++) 
   {
      array[i, j] = new Random().NextDouble()*100;
   }
}

for(int i=0; i < m; i++)
{
    for(int j=0; j<n; j++)
    {
        Console.Write(array[i, j] + " ");
    }

    Console.WriteLine();
}
