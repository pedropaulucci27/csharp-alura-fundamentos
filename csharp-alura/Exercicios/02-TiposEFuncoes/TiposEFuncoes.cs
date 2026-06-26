// Exercício 2 — Tipos e Funções

// Quest 1 — Operações básicas
void efetuarOperacoes(float a, float b)
{
    float soma = a + b;
    float multiplicacao = a * b;
    float divisao = a / b;
    float subtracao = a - b;

    Console.WriteLine($"Adição: {soma}");
    Console.WriteLine($"Subtração: {subtracao}");
    Console.WriteLine($"Multiplicação: {multiplicacao}");
    Console.WriteLine($"Divisão: {divisao}");
}

efetuarOperacoes(5, 6);

// Quest 2 — Lista de bandas
List<string> bandas = new List<string>();
bandas.Add("U2");
bandas.Add("The Beatles");

// Quest 3 — Exibir bandas com for
Console.WriteLine();
for (int i = 0; i < bandas.Count; i++)
{
    Console.WriteLine(bandas[i]);
}

// Quest 4 — Soma de inteiros
Console.WriteLine();
List<int> inteiros = new List<int> { 1, 6, 8, 10, 20 };
int soma = 0;
for (int i = 0; i < inteiros.Count; i++)
{
    soma = soma + inteiros[i];
}
Console.WriteLine(soma);
