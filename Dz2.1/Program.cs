// Программа которая выводит случайное число и удаляет вторую цифру

int number = RandomInt(100, 1000);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);
Console.WriteLine($"{stringNumber[1]}{stringNumber[2]}");

int RandomInt(int enclusiveMin,int exlusiveMax)
{
    return new Random().Next(enclusiveMin,exlusiveMax);
}
