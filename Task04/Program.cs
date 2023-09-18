//Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
//2, 3, 7 -> 7
//44 5 78 -> 78
//22 3 9 -> 22
Console.Write("Enter first number: ");
int numberA = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter second number: ");
int numberB = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter third number: ");
int numberC = Convert.ToInt32(Console.ReadLine());
int numberMax = numberA;
if (numberB > numberMax) numberMax = numberB;
if (numberC > numberMax) numberMax = numberC;
Console.Write($"{numberA}, {numberB}, {numberC} -> {numberMax}");
