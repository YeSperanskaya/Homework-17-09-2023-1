//Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
//5 -> 2, 4
//8 -> 2, 4, 6, 8
Console.Write("Enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
int count = 4;
string scroll = "2";
if (number >= 2)
{ 
    while(count <= number)
    {
        scroll = $"{scroll}, {count}";
        count = count + 2;
    }
    Console.Write($"{number} -> {scroll}");
}
else
{
    Console.Write("Please, restart this programm");
}
