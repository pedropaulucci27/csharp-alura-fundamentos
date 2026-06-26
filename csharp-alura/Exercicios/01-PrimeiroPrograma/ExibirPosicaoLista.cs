// Exercício 1 — Exibir Posição de uma Lista
List<string> listaNomes = new List<string>();
string nome1 = "Pedro";
string nome2 = "Mari";
string nome3 = "João";
listaNomes.Add(nome1);
listaNomes.Add(nome2);
listaNomes.Add(nome3);

Console.WriteLine("Digite a posição que deseja ver: ");
int posicao = int.Parse(Console.ReadLine());

void ExibirPosicao(int num)
{
    if (num < 0 || num >= listaNomes.Count)
    {
        Console.WriteLine("Posição inválida!");
    }
    else
    {
        Console.WriteLine(listaNomes[num]);
    }
}

ExibirPosicao(posicao);
