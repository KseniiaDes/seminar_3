// Задача 22: Напишите программу, которая
// принимает на вход число (N) 
// и выдаёт таблицу квадратов чисел от 1 до N.

Console.Write("Введите натуральное число: ");
int number = Convert.ToInt32(Console.ReadLine());

void Squares(int num)
{
    for (int i = 1; i <= num; i++)
    {
        Console.WriteLine($"{i, 4}    {i * i, 4}");
    }
}

if (number > 0) Squares(number);
else Console.WriteLine("Число не является натуральным");