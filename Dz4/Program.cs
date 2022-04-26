// Программа которая на вход принимает число (N), а на выходе показываект все четные
// числа от 1 до N.
Console.Write("Введите целое положительное число" );
int N = Convert.ToInt32(Console.ReadLine());
int i = 2;

while (i<=N)
{
    Console.Write(i);
    i+=2;
    if (i<=N)
    Console.Write(", ");
}











