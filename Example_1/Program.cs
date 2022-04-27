/*Задача 1: Напишите программу, которая на вход
принимает два числа и выдаёт, какое число большее, а
какое меньшее.
a = 5; b = 7 -> max = 7
a = 2 b = 10 -> max = 10
a = -9 b = -3 -> max = -3
*/
//Вариант 1
Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 > Number2)
{
    Console.WriteLine("Max = " + Number1+", Min = "+ Number2);
}
if (Number1 < Number2)
{
    Console.WriteLine("Max = " + Number2+", Min = "+ Number1);
    
}
else
{
    Console.WriteLine("Max и Min значения не найдены! Введены одинаковые числа.");
}
// Вариант 2
/*
Console.Write("Введите первое число: ");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе число: ");
int Number2 = Convert.ToInt32(Console.ReadLine());
int Max = Math.Max(Number1,Number2);
int Min = Math.Min(Number1,Number2);
Console.WriteLine("Max = " + Max+", Min = "+ Min);
*/