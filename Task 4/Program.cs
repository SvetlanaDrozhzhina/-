int max = 0;
Console.WriteLine("Введите первое число:  ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:  ");
int b = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите третье число:  ");
int e = int.Parse(Console.ReadLine()!);
if (a > max)
{
    max = a;
}
if (b > max)
{
    max = b;
}
if (e > max)
{
    max = e;
}
Console.WriteLine("max = " + max);