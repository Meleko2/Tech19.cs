int a, b, c, n, suma=0, dzielnik=0, ilosc=0, rytm, iloczyn, licznik, mianownik, silnia, ciag1, ciag2, fib1, fib2, sumafib;

//Zadania 1
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());

// C. arytmetyczny
if (b - a == c - b) Console.WriteLine("Jest arytmetyczny");
if (b / a == c / b) Console.WriteLine("Jest geometryczny");


//Zadania 2
for (int i = 100; i < 1000; i++)
{
    if (i % 8 == 0 && i % 16 != 0)
        suma += i;
}
Console.WriteLine(suma);


//Zadania 3
for (int i = 99; i > 10; i--)
{
    if (i % 7 == 0)
    {
        dzielnik = i;
        break;
    }
}

for (int j = 1000; j < 10000; j++)
{
    if (j % dzielnik == 0)
    {
        ilosc++;
    }
}
Console.WriteLine(ilosc);

//Zadania 4
ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if ((int)i / 10 > (i % 10) * 2)
        ilosc++;
}
Console.WriteLine(ilosc);

//Zadania 5
suma = 0;
ilosc = 0;
for (int i = 100; i < 1000; i++)
{
    if ((int)i / 100 > (i % 100) / 10 + i % 10)
    {
        ilosc++;
        suma += i;
    }
}
Console.WriteLine(suma);

//Zadania 6
n = Convert.ToInt32(Console.ReadLine());
suma = 0;
ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if (i % 19 == 0)
    {
        ilosc++;
        suma += i;
    }
    if (ilosc == n)
    {
        Console.WriteLine(suma);
        break;
    }
    if (ilosc == 99)
    {
        Console.WriteLine("Out of range");
    }
}

//Zadania 7
n = Convert.ToInt32((Console.ReadLine()));
suma = 0;
ilosc = 0;
for (int i = 999; i < 100; i--)
{
    if (i % 37 == 0)
    {
        ilosc++;
        suma += i;
    }
    if (ilosc == n)
    {
        Console.WriteLine(suma);
        break;
    }
    if (ilosc == 100)
    {
        Console.WriteLine("Out of range");
    }
}

