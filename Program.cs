﻿Console.WriteLine("Soletrar");

Console.Write("escreva aqui seu texto: ");
string soletrar;
soletrar=Console.ReadLine()!;
for (int i = 0; i < soletrar.Length; i++)
{
    Console.Write(soletrar[i]);
    if (i < soletrar.Length-1)
    {
        Console.Write("-");
    }
}
Console.WriteLine();
