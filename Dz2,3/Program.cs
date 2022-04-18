// программакоторая принимает на взод трехзначное число, а на выходе показыает вторую цифру.


int number = Convert.ToInt32(Console.ReadLine());
string stringNumber = Convert.ToString(number);
Console.WriteLine($"{stringNumber[1]}");


