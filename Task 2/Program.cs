int max = 0;
int min = 0;
Console.WriteLine("Введите первое число:  ");
int a = int.Parse(Console.ReadLine()!);
Console.WriteLine("Введите второе число:  ");
int b = int.Parse(Console.ReadLine()!);
if(a > b)
{
    max = a;
    min = b;
}
else
{
    max = b;
    min = a;
}
Console.WriteLine("max = " + max + " и " + "min = " + min);