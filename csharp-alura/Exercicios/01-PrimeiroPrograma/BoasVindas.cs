// Exercício 1 — Boas Vindas
Console.WriteLine("Digite o nome do aluno");
string nomeAluno = Console.ReadLine();

void ExibirBoasVindas(string nome)
{
    Console.WriteLine($"Olá {nome}");
}

ExibirBoasVindas(nomeAluno);
