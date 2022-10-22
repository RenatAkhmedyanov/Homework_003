Console.WriteLine("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в N-мерном пространстве.");

Console.Write("Введите число N: ");
int N = int.Parse(Console.ReadLine()!);

double Distance(int[] dotA, int[] dotB)
{
    double sum = 0;
    for (int i = 0; i < N; i++){
        sum = sum + Math.Pow(dotB[i] - dotA[i], 2);        
    }
    return Math.Sqrt(sum);
}

int[] dotA = new int[N];
int[] dotB = new int[N];

Console.Write("Введите координаты первой точки: ");
for (int i = 0; i < N; i++)
{
    dotA[i] = int.Parse(Console.ReadLine()!);    
}
Console.Write("Координаты первой точки: ");
for (int i = 0; i < N; i++)
{
    Console.Write(dotA[i] + " ");    
}
Console.WriteLine();
Console.Write("Введите координаты второй точки: ");
for (int i = 0; i < N; i++)
{
    dotB[i] = int.Parse(Console.ReadLine()!);    
}
Console.Write("Координаты второй точки: ");
for (int i = 0; i < N; i++)
{
    Console.Write(dotB[i] + " ");    
}
Console.WriteLine();
Console.WriteLine("Расстояниие между точками: " + Math.Round(Distance(dotA, dotB), 3));
