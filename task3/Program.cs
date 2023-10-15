// Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, 
// является ли этот день выходным.

Console.Write("Введите номер дня недели");
int day = Convert.ToInt32(Console.ReadLine());

if(day > 0 && day < 6)
{
    Console.WriteLine("Нет");
}
else if(day > 5 && day < 8)
{
    Console.WriteLine("Да");
}
else if(day > 7 || day <= 0)
{
    Console.WriteLine("Такого дня недели нет");
} 
