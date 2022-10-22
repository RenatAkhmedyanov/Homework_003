Console.WriteLine("Программа, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.");

double Distance(int[] dotA, int[] dotB)
{
    return Math.Sqrt(Math.Pow(dotB[0] - dotA[0], 2) + Math.Pow(dotB[1] - dotA[1], 2) + Math.Pow(dotB[2] - dotA[2], 2));
}

int[] dotA = new int[3];
int[] dotB = new int[3];

Console.Write("Введите первую координату первой точки: ");
dotA[0] = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату первой точки: ");
dotA[1] = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью координату первой точки: ");
dotA[2] = int.Parse(Console.ReadLine()!);

Console.Write("Введите первую координату второй точки: ");
dotB[0] = int.Parse(Console.ReadLine()!);
Console.Write("Введите вторую координату второй точки: ");
dotB[1] = int.Parse(Console.ReadLine()!);
Console.Write("Введите третью координату второй точки: ");
dotB[2] = int.Parse(Console.ReadLine()!);

Console.WriteLine(Math.Round(Distance(dotA, dotB), 3));