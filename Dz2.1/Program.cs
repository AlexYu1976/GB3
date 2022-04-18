// Программа которая выводит случайное число и удаляет вторую цифру

int number = RandomInt(100, 1000);
Console.WriteLine(number);
string stringNumber = Convert.Tostring(number);
Console.WriteLine($"{stringNumder[0]}{stringNumber[2]}");

int RandomInt(int anclusiveMin,int axlusiveMax)
{
    return new Random().Next(anclusiveMin,axlusiveMax);
}
