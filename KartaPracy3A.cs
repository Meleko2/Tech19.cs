//Zad 1
int n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    System.Console.Write("*-|");
}
Console.WriteLine();


//Zad 5
n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (j == n / 2 + 1)
        {
            Console.Write("*");
        }
        else if (i == n / 2 + 1)
        {
            Console.Write("-");
        }
        else
        {
            Console.Write(" ");
        }

    }
    Console.WriteLine();
}
Console.WriteLine();


//Zad 6



//Zad 7
n = int.Parse(Console.ReadLine());
for (int i = 1; i < n + 1; i++)
{
    for (int j = 1; j < n + 1; j++)
    {
        if (i == 1 || j == 1 || j == n || i == n || (i == n / 2 + 1 && j == n / 2 + 1))
        {
            Console.Write("*");
        }
        else
        {
            Console.Write(" ");
        }
    }
    Console.WriteLine();
}