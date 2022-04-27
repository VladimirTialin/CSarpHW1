/*
Задача 2: Напишите программу, которая принимает на
вход три числа и выдаёт максимальное из этих чисел.
2, 3, 7 -> 7
44 5 78 -> 78
22 3 9 -> 22
*/
int[] numbers = new int [3];
Console.WriteLine("Введите 3 числа: ");
int MaxNumber = numbers[0];
for (byte i = 0; i < numbers.Length; i++)
{
    int number = Convert.ToInt32(Console.ReadLine());
    numbers[i] = number;
}
for (byte i = 0; i < numbers.Length; i++)
{
    if (MaxNumber < numbers[i])
    {
        MaxNumber = numbers[i];
    }
}
Console.WriteLine("Max = "+MaxNumber);