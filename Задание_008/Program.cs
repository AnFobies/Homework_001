/*Программа, которая на вход принимает число (N) 
и на выходе показывает все чётные числа от 1 до N*/

Console.WriteLine("Укажите число: ");
int number = int.Parse(Console.ReadLine());
int count = 2;

if(number < 2)
{
    Console.Write($"Четных чисел от одного до 1 до {number}");
}

if(number >= 2)
{
    do
    {
        Console.Write($"{count}, ");
        count = count + 2;
    }
    while(count <= number);
}