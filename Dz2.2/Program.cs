// Программа которая выводит третью цифру заданного числа или говорит что ее нет.


int number = RandomInt(1,200);
Console.WriteLine(number);
string stringNumber = Convert.ToString(number);

if (number%100 == number)
{
    Console.WriteLine("Третьей цифры нет ");
}
else
{
    Console.WriteLine($"{stringNumber[2]}");
}

int RandomInt(int enclusiveMin,int exlusiveMax)
{
    return new Random().Next(enclusiveMin, exlusiveMax);
}

  

