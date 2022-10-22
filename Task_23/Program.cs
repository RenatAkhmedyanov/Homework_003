Console.WriteLine("Программа, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.");

Console.Write("Введите положительное число: ");
int N = int.Parse(Console.ReadLine()!);

if (N <= 0)
{
    Console.WriteLine("Ошибка ввода!");
}
else
{
    int[] GetCubeTable(int N)
    {
        int[] CubeArray = new int[N];
        for (int i = 0; i < N; i++)
        {
            CubeArray[i] = (i + 1) * (i + 1) * (i + 1);
        }
        return CubeArray;
    }

    void PrintTable(int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            Console.Write(Array[i] + " ");
        }
    }

    int[] CubeTable = GetCubeTable(N);
    PrintTable(CubeTable);
}
