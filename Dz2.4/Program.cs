// Программа которая принимает на вход цифру, обозначающую
// день недели и проверяет является ли этот день выходным.

Console.WriteLine("Ведите цифру от 1 до 7 ");
int day = Convert.ToInt32(Console.ReadLine());
Console.WriteLine(Week(day) + "-" + CheckHollyday(Week(day)));


string Week(int day)
{

    if (day==1)
    {
        stringDay = ConvertToString(day);
        stringDay = "Пн";
        return stringDay;
    }
    if (day==2)
    {
        stringDay = ConvertToString(day);
        stringDay = "Вт";
        return stringDay; 
    }

    if (day==3)
    {
        stringDay = ConvertToString(day);
        stringDay = "Ср";
        return stringDay; 

    }
        if (day==4)
    {
        stringDay = ConvertToString(day);
        stringDay = "Чт";
        return stringDay; 
    }
        if (day==5)
    {
        stringDay = ConvertToString(day);
        stringDay = "Пт";
        return stringDay; 
    }
        if (day==6)
    {
        stringDay = ConvertToString(day);
        stringDay = "Сб";
        return stringDay; 
    }   
        if (day==7)
    {
        stringDay = ConvertToString(day);
        stringDay = "Вс";
        return stringDay; 
    }
}

