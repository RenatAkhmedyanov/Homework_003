Console.WriteLine("Программа, принимает на вход целое число любой разрядности и проверяет, является ли оно палиндромом.");

Console.Write("Введите количество цифр в числе: ");
int N = int.Parse(Console.ReadLine()!);

Console.Write("Введите число: ");
int input = int.Parse(Console.ReadLine()!);
int temp = input;

int[] firstArray = new int[N];
for (int i = 0; i < N; i++)
{
    firstArray[i] = input % 10;
    input = input / 10;
}

int[] secondArray = new int[N];
for (int i = N - 1; i >= 0; i--)
{
    secondArray[i] = temp % 10;
    temp /= 10;
}

bool isEqual = Enumerable.SequenceEqual(firstArray, secondArray);

if (isEqual)
{
    Console.WriteLine("Число является палиндромом.");
}
else
{
    Console.WriteLine("Число не является палиндромом.");
}