Console.WriteLine("Введите число N: "); 
int N = int.Parse(Console.ReadLine()!); 
int number = 2;
if (N > 1)
{
    while(number <= N)
    {
        Console.Write(number + " ");
        number = number +2;
    }
}