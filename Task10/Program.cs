// Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// 918 -> 1
int SecondDigit (int num)
{
    int twoDigit = num / 10;
    int secondDigit = twoDigit % 10;
    return secondDigit;
}

Console.WriteLine("Hello! Please enter three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 1000 && number > 99)
{
    int secondNumber = SecondDigit(number);
    Console.WriteLine($"{number} -> {secondNumber}");
}
else
{
    Console.WriteLine("Please, restart this program");
}