// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

bool DayOff (int num)
{
    return num > 5;  
}

Console.WriteLine("Please, enter day of the week number (1-7): ");
int number = Convert.ToInt32(Console.ReadLine());
if (number > 7)
{
    Console.WriteLine("Oops! Please, restart this program!");
}
else
{
    bool result = DayOff(number);
    Console.WriteLine(result ? $"{number} -> yes" : $"{number} -> no");
}
//number > 7 go away
// else method
