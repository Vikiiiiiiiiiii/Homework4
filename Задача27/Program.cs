/*Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
452 -> 11
82 -> 10
9012 -> 12*/


Console.WriteLine("Введите число N: ");
int n = Convert.ToInt32(Console.ReadLine());
int summ = 0; //сумма цифр в числе

while (n > 0)
{
    int digit = n % 10; 
    summ += digit;
    n = n/10;
}

Console.WriteLine($"Сумма всех цифр в заданном числе = {summ}");

