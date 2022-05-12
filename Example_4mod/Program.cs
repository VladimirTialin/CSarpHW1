/*Задача 4: Напишите программу, которая на вход
принимает число (N), а на выходе показывает все чётные
числа от 1 до N.
5 -> 2, 4
8 -> 2, 4, 6, 8
*/
//Я плохо прочел условия задачи, в итоге сделал динамический массив, который выводит все четные цифры
int [] numbers = new int [2];  
Console.WriteLine("Введите N-е количество чисел");
Console.WriteLine("Для завершения операции введите пробел");
try
{
    for (int i = 0; i < numbers.Length; i++)
    {
        Array.Resize (ref numbers, numbers.Length + 1);
        int number = Convert.ToInt32(Console.ReadLine());
        numbers[i] = number; 
    }
}
catch
{
    Array.Resize (ref numbers, numbers.Length - 3);
}
finally
{
 Console.Write("Введенные числа являются четными: | ");  
for (int i = 0; i < numbers.Length; i++)
    if (numbers[i] % 2 == 0)
    {
        if (numbers[i] != 0)
        {
         Console.Write(numbers[i]+" | ");
        }
    }    
}
//Для печати массива:
//string arraystring = string.Join (", ", numbers);
//System.Console.WriteLine();
//System.Console.WriteLine(arraystring);