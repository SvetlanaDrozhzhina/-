Console.WriteLine("Введите число:  ");
int number = int.Parse(Console.ReadLine()!);
int remDiv = number % 2;
if(remDiv == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}