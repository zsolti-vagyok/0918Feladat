using System;

//1.Eldöntés(for ciklussal)
   
int[] tomb = { 1, 3, -5, 7, 9 };
bool talalat = false;
for (int i = 0; i < tomb.Length; i++)
{
    if (tomb[i] < 0) // Feltétel: negatív szám keresése
    {
        talalat = true;
        break; // Ha megtaláljuk, kilépünk a ciklusból
    }
}

if (talalat)
{
    Console.WriteLine("Van negatív szám a tömbben.");
}
else
{
    Console.WriteLine("Nincs negatív szám a tömbben.");
}

//2.Összegzés(for ciklussal)
   
int[] tomb1 = { 1, 2, 3, 4, 5 };
int osszeg = 0;

for (int i = 0; i < tomb.Length; i++)
{
    osszeg += tomb[i];
}

Console.WriteLine("A tömb elemeinek összege: " + osszeg);

//3.Kiválasztás(for ciklussal)
  
int[] tomb2 = { 1, 3, 5, 6, 7 };
int kivalasztottElem = 0;
bool megtalalva = false;

for (int i = 0; i < tomb.Length; i++)
{
    if (tomb[i] % 2 == 0) // Feltétel: páros szám keresése
    {
        kivalasztottElem = tomb[i];
        megtalalva = true;
        break; // Ha megtaláljuk, kilépünk a ciklusból
    }
}

if (megtalalva)
{
    Console.WriteLine("Az első páros szám: " + kivalasztottElem);
}
else
{
    Console.WriteLine("Nincs páros szám a tömbben.");
}

//4.Lineáris keresés(for ciklussal)
   
int[] tomb3 = { 1, 2, 3, 4, 7, 9 };
int keresettElem = 7;
int index = -1; // -1, ha nincs meg az elem

for (int i = 0; i < tomb.Length; i++)
{
    if (tomb[i] == keresettElem)
    {
        index = i;
        break; // Ha megtaláljuk, kilépünk a ciklusból
    }
}

if (index != -1)
{
    Console.WriteLine("A keresett elem indexe: " + index);
}
else
{
    Console.WriteLine("A keresett elem nem található.");
}