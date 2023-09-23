// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6
int ThirdNumber (int num)
{
    while (num > 999)
    {
        num = num / 10;
    }
    int thirdNumber = num % 10;
    return thirdNumber;
} 

Console.WriteLine("Please, enter your number: ");
int number = Convert.ToInt32(Console.ReadLine());
if (number < 100)
{
    Console.WriteLine($"{number} -> third number doesn't exist");
}
else 
{
    int thirdNumber = ThirdNumber(number);
    Console.WriteLine($"{number} -> {thirdNumber}");
}

