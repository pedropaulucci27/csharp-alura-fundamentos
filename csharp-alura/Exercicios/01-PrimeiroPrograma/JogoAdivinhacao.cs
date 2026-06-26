// Exercício 1 — Jogo: Adivinhe o Número Secreto
Random numeroAleatorio = new Random();
int numeroSecreto = numeroAleatorio.Next(1, 101);

do
{
    Console.WriteLine("Tente acertar o número secreto:");
    int tentativa = int.Parse(Console.ReadLine());

    switch (tentativa.CompareTo(numeroSecreto))
    {
        case 0:
            Console.WriteLine("Você acertou!");
            break;
        case 1:
            Console.WriteLine("O número digitado é maior que o número secreto!");
            break;
        case -1:
            Console.WriteLine("O número digitado é menor que o número secreto!");
            break;
    }

    if (tentativa == numeroSecreto)
        break;
}
while (true);
