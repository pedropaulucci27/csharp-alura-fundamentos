// Exercício 3 — Listas e Loops
// Exibir apenas números pares usando for e foreach

List<int> inteiros = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };

// Com for
Console.WriteLine("Números pares (for):");
for (int i = 0; i < inteiros.Count; i++)
{
    if (inteiros[i] % 2 == 0)
    {
        Console.WriteLine(inteiros[i]);
    }
}

// Com foreach
Console.WriteLine("Números pares (foreach):");
foreach (int inteiro in inteiros)
{
    if (inteiro % 2 == 0)
    {
        Console.WriteLine(inteiro);
    }
}
