/*Программа, которая на вход принимает число и выдаёт, 
является ли оно чётным*/

Console.WriteLine("Укажите число: ");
int number1 = int.Parse(Console.ReadLine());

if(number1%2 == 0)
{
    Console.WriteLine("Это число является четным!");
}
else
{
    Console.WriteLine("Это число является нечетным!");
}