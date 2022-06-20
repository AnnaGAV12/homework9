// Показать натуральные числа от M до N, N и M заданы
void PrintNumbers(int min, int max)
{
    if (max < min)
    {
        Console.WriteLine();
        return;
    }
    Console.Write(min + " ");
    PrintNumbers(min + 1, max);
}
Console.Clear();
Console.Write("Введите число M: ");
int m = int.Parse(Console.ReadLine() ?? "0");
Console.Write("Введите число N: ");
int n = int.Parse(Console.ReadLine() ?? "0");
if (m <= 0 || n <= 0)
    Console.WriteLine("Введены не натуральные числа!");
else if (m > n)
{
    int tmp = m; m = n; n = tmp;
    PrintNumbers(m, n);
}
else PrintNumbers(m, n);
