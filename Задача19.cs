/* Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет

12821 -> да

23432 -> да  */


Console.WriteLine("Введите 5-ти значное число");
string chislo = Console.ReadLine();
chislo = chislo.ToLower();
string newchislo = "";
for (int i = chislo.Length - 1; i >= 0; i--)
{
    newchislo = newchislo + chislo[i]; 
}

if (chislo == newchislo)
Console.WriteLine($"{newchislo} - палиндром");
else
Console.WriteLine("Неверно");
