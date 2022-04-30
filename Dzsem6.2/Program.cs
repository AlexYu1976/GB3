// Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3



//РЕШЕНИЕ
Console.WriteLine("Введите длину массива ");
int length = Convert.ToInt32(Console.ReadLine());
double[] array = new double[length];

for (int i = 0; i < length; i++)
{
    Console.WriteLine($"Введите {i} элемент массива");
    array[i] = Convert.ToDouble(Console.ReadLine());
}
int count = 0;
for(int i = 0; i<length;i++)
{
    if(array[i]>0)
    {
        count++; 
    }
    else
    {
        count = count + 0;
    }    
}
Console.WriteLine($"Количество положительных чисел в массиве = {count} ");
