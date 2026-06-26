// Exercício 4.1 — Média de notas de um aluno
Dictionary<string, List<float>> alunos = new Dictionary<string, List<float>>();
alunos.Add("Pedro", new List<float> { 9, 9, 10 });

foreach (string aluno in alunos.Keys)
{
    float soma = 0;

    foreach (float nota in alunos[aluno])
    {
        soma += nota;
    }

    float media = soma / alunos[aluno].Count;
    Console.WriteLine($"Aluno: {aluno} - Média: {media}");
}
