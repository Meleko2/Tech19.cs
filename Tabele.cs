//Tablice - (zmienna do trzymania wielu zmiennych
int[] T = new int[5];
T[0] = 3;
T[1] = 5;
T[2] = 6;
T[3] = 7;
T[4] = 10;


for (int i = 0; i < T.Length; i++)
{
    Console.WriteLine(T[i]);
}

Console.WriteLine();

//To taki niezalecany zapis
int[] A = { 2, 3, 5, 8, 13, 21, 34, 55 };
for (int i = 0; i < A.Length; i++)
{
    Console.WriteLine($"K[{i}] = {A[i]}");
}

int[] G;
G = new int[] { 1, 3, 5 };

Console.WriteLine();

//Znajdz maksymalna wartosc tablicy [4,5,8,9,7,6]
int[] L = new int[]
{ 4, 5, 8, 9, 7, 6 };

int maks = 0;
for (int i = 0; i < L.Length; i++)
{
    if (L[i] > maks)
    {
        maks = L[i];
    }
}
Console.WriteLine($"Najwieksza wartosc w tej talbicy to: {maks}");

Console.WriteLine();

//Znajdz najnizsza wartosc w talibcy [6,2,1,3,9,5]
int[] H = new int[]
{6,2,1,3,9,5,};

int minimum = L[0];
for (int i = 0; i < H.Length; i++)
{
    if (H[i] < minimum)
    {
        minimum = H[i];
    }
}
Console.WriteLine($"Najmniejsza wartosc w tej talbicy to: {minimum}");