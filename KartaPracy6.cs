﻿int a, b, c, suma, dzielnik, ilosc, n, skladnik, wynik;
//Zadania 1
Console.Write("Podaj liczbe1: ");
a = int.Parse(Console.ReadLine());
Console.Write("Podaj liczbe2: ");
b = int.Parse(Console.ReadLine());
Console.Write("Podaj liczbe3: ");
c = int.Parse(Console.ReadLine());
if (b - a == c - b) 
    Console.WriteLine("Ciag jest arytmetyczny");
if (b / a == c / b) 
    Console.WriteLine("Ciag jest geometryczny");
Console.WriteLine();

//Zadania 2
suma = 0;
for (int i = 100; i < 1000; i++)
{
    if (i % 8 == 0 && i % 16 != 0)
        suma += i;
}
Console.WriteLine($"Suma liczb trzycyfrowych podzielnych przez 8 ale niepodzielnych przez 16 wynosi: {suma}");
Console.WriteLine();

//Zadania 3
dzielnik = 0;
ilosc = 0;
for (int i = 99; i < 10; i--)
{
    if (i % 7 == 0)
        dzielnik = i;
        break;
}
for (int j = 1000; j < 10000; j++)
{
    if (j % dzielnik == 0)
        ilosc++;
}
Console.WriteLine($"Ilosc liczb czterocyfrowych bedacymi wieloktnosciami najwiekszej liczby dwucryfrowej podzielnej przez 7 wynosi: {ilosc}");
Console.WriteLine();

//Zadania 4
ilosc = 0;
for (int i = 10; i < 100; i++)
{
    if ((i%10)*2 == i/10)
        ilosc++;
}
Console.WriteLine($"Ilosc liczb dwucyfrowych w ktorych cyfra dziesiatek jest 2 razy wieksza niz cyfra jednosci");

//Zadania 5
suma = 0;
ilosc = 0;
for (int i = 100; i < 1000; i++)
{
    if (i / 100 > i % 10 + i / 10)
        suma += i;
        ilosc++;
}
Console.WriteLine($"Suma liczb trzycyfrowych w ktorych liczb setek jest wieksza od sumy liczby dziesiatek i jednosci wynosi {suma} a ilosc takich liczb wynosi: {ilosc}");

//Zadania 6
n = int.Parse(Console.ReadLine());
//NO IDEA

//Zadania 7
n = int.Parse(Console.ReadLine());
suma = 0;
skladnik = 0;
for (int j=999 ; j>100 ; j++)
{
    if(j%37==0)
    {
        skladnik = j;
        break;
    }
}
for (int i=0 ; i<n ; i++)
{
    suma += (skladnik-37*i);
}
System.Console.WriteLine(suma);

// Zadania 8

suma = 0;
n = int.Parse(Console.ReadLine());
for (int i = 1 ; i <= n ; i++)
{
   suma = suma + ((3*i-1)*((int) Math.Pow(-1,i-1)));
}
System.Console.WriteLine(suma);

//Zadania 9 - TODO

//Zadania 10
wynik = 1;
suma = 0;
n = int.Parse(Console.ReadLine());
for (int i = 0; i < n; i++)
{
    wynik=1;
    for (int j = 0; j < i; j++)
    {
        wynik *= j;
    }
    suma += wynik;
}
Console.WriteLine($"Suma n pierwszych tego ciagu: {suma}");

//Zadania 11
suma = 0;
n = int.Parse(Console.ReadLine());
for (int i = 1 ; i <= n ; i++)
{
    suma += (2 * i - 1) / Math.Pow(i, 2);
}
System.Console.WriteLine(suma);