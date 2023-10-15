//  Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую 
// цифру этого числа.

Console.Write("Введите трехзначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

if(number > 99 && number < 1000)
{
    int digit = number / 10 % 10;
    Console.WriteLine(digit);
}
else
{
    Console.WriteLine("Вы ввели не трехзначное число");
}
