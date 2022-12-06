/*Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
3, 5 -> 243 (3⁵)
2, 4 -> 16

(результат многократного умножения числа на себя).*/ 

Console.Write("Введите число A: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.Write("Введите число B: ");
int b = Convert.ToInt32(Console.ReadLine());

int naturalStep = a;

for (int i = 1; i < b; i++)
    {
        naturalStep *= a;
    }
    
Console.WriteLine("Число A в степени B равно: " + naturalStep);


