Console.WriteLine("Программа, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.");

Console.Write("Введите положительное пятизначное число: ");
int input = int.Parse(Console.ReadLine()!);

if (input > 9999 && input < 100000)
{
    int firstDigit = input / 10000;
    int secondDigit = (input / 1000) % 10;
    int fourthDigit = (input / 10) % 10;
    int fifthDigit = input % 10;
    if (IsPalindrome(firstDigit, secondDigit, fourthDigit, fifthDigit))
    {
        Console.WriteLine("Число является палиндромом.");
    }
    else
    {
        Console.WriteLine("Число не является палиндромом.");
    }
}
else
{
    Console.WriteLine("Некорректный ввод!");
}

bool IsPalindrome(int firstDigit, int secondDigit, int fourthDigit, int fifthDigit)
{
    return firstDigit == fifthDigit && secondDigit == fourthDigit;
}