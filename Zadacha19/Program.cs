// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

Console.Write("Введите пятизначное число ");
int a = Convert.ToInt32(Console.ReadLine());

if (a > 999 && a < 100000)
{
    string str = a.ToString();
    if (str[0] == str[4] && str[1] == str[3])
    {
        Console.WriteLine("Да");
    }
    else
    {
        Console.WriteLine("Нет");
    }
}
else
{
    Console.WriteLine("Введеное число не пятизначное");
}