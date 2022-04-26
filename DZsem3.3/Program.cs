// Задача 38: 
//Задайте массив вещественных чисел.
// Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

Console.WriteLine("Введите длину массива ");
int Length = Convert.ToInt32(Console.ReadLine());
double[] numbers = new double[Length];
FillArray(numbers);
PrintArray(numbers);
Max(numbers);
Console.WriteLine("Максимальный элемент массива " + Max(numbers));
Min(numbers);
Console.WriteLine("Минимальный элемент массива " + Min(numbers));
double result = Max(numbers) - Min(numbers);
Console.WriteLine("Разница между максимальным и минимальным элементом маасива = " +result);

void FillArray(double[] array) // Задали массив
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(1, 100);
    }
}


void PrintArray(double[] array1) // Вывели массив на экран
{
    for(int i = 0; i < array1.Length; i++)
    {
        Console.Write(array1[i]+ " ");
       
    }
    Console.WriteLine();
}

double Max(double[] numbers) // Метод нахождения максимального элемента массива
{
    double maxValue = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] > maxValue)
        {
            maxValue = numbers[i];
        }
    }
    return maxValue;
}

double Min(double[] numbers) // Метод нахождения минимального элемента иассива
{
    double minValue = numbers[0];
    for (int i = 0; i < numbers.Length; i++)
    {
        if (numbers[i] < minValue)
        {
            minValue = numbers[i];
        }
    }
    return minValue;
}




