/*Программа, которая на вход принимает два числа и выдаёт, 
какое число большее, а какое меньшее*/

Console.WriteLine("Укажите первое число: ");
int number1 = int.Parse(Console.ReadLine());
Console.WriteLine("Укажите второе число: ");
int number2 = int.Parse(Console.ReadLine());

if(number1 > number2)
{
    Console.WriteLine($"Наибольшее число {number1}, а наименьшее {number2}");
}
else
{
    Console.WriteLine($"Наибольшее число {number2}, а наименьшее {number1}");
}