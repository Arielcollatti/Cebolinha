Console.WriteLine("--- Cebolinha ---\n");
string digite, fraseCebolinha;

Console.Write("digite uma frase:  ");
digite = Console.ReadLine()!;

fraseCebolinha = digite
     .Replace("r","l")
     .Replace("R","L");

Console.WriteLine($"\nA frase digitada pelo cebolinha é: {fraseCebolinha}");