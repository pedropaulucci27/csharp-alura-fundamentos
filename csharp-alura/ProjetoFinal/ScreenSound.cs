// Projeto Final — Screen Sound
// Sistema de avaliação de bandas musicais

string mensagemDeBoasVindas = "Bem vindo ao Screen Sound!";

Dictionary<string, List<int>> bandasRegistradas = new Dictionary<string, List<int>>();
bandasRegistradas.Add("Link Park", new List<int> { 10, 8, 6 });
bandasRegistradas.Add("The Beatles", new List<int>());

void ExibirLogo()
{
    Console.WriteLine(@"

█▀ █▀▀ █▀█ █▀▀ █▀▀ █▄░█   █▀ █▀█ █░█ █▄░█ █▀▄
▄█ █▄▄ █▀▄ ██▄ ██▄ █░▀█   ▄█ █▄█ █▄█ █░▀█ █▄▀
");
    Console.WriteLine(mensagemDeBoasVindas);
}

void ExibirTituloDaOpcao(string titulo)
{
    int quantidadeLetras = titulo.Length;
    string asteriscos = string.Empty.PadLeft(quantidadeLetras, '*');
    Console.WriteLine(asteriscos);
    Console.WriteLine(titulo);
    Console.WriteLine(asteriscos + "\n");
}

void ExibirOpcoesDoMenu()
{
    ExibirLogo();
    Console.WriteLine("\n1- Registrar uma banda");
    Console.WriteLine("2- Mostrar todas as bandas");
    Console.WriteLine("3- Avaliar uma banda");
    Console.WriteLine("4- Exibir a média de uma banda");
    Console.WriteLine("0- Sair");

    Console.Write("\nDigite a sua opção: ");
    string opcaoEscolhida = Console.ReadLine();
    int opcaoEscolhidaNumerica = int.Parse(opcaoEscolhida);

    switch (opcaoEscolhidaNumerica)
    {
        case 1:
            RegistrarBanda();
            break;
        case 2:
            ExibirBandasRegistradas();
            break;
        case 3:
            AvaliarBanda();
            break;
        case 4:
            ExibirMedia();
            break;
        case 0:
            Console.WriteLine("Saindo do menu...");
            break;
        default:
            Console.WriteLine("Opção inválida!");
            break;
    }
}

void RegistrarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Registro das bandas");
    Console.Write("Digite o nome da banda que deseja registrar: ");
    string nomeDaBanda = Console.ReadLine();
    bandasRegistradas.Add(nomeDaBanda, new List<int>());
    Console.WriteLine($"A banda {nomeDaBanda} foi registrada com sucesso");
    Thread.Sleep(2000);
    ExibirOpcoesDoMenu();
}

void ExibirBandasRegistradas()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibindo todas as bandas registradas");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
    Console.ReadKey();
    Console.Clear();
    ExibirOpcoesDoMenu();
}

void AvaliarBanda()
{
    Console.Clear();
    ExibirTituloDaOpcao("Avaliar banda");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.Write("Digite o nome da banda que deseja avaliar: ");
    string nomeBanda = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(nomeBanda))
    {
        Console.WriteLine($"Digite a nota da banda {nomeBanda} de 0 a 10: ");
        int nota = int.Parse(Console.ReadLine()!);
        bandasRegistradas[nomeBanda].Add(nota);
        Console.WriteLine($"A nota {nota} foi registrada com sucesso para a banda {nomeBanda}");
        Thread.Sleep(4000);
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine($"A banda {nomeBanda} não foi encontrada");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

void ExibirMedia()
{
    Console.Clear();
    ExibirTituloDaOpcao("Exibir média de uma banda");
    Console.WriteLine("");

    foreach (string banda in bandasRegistradas.Keys)
    {
        Console.WriteLine($"Banda: {banda}");
    }

    Console.WriteLine("Escolha uma banda: ");
    string bandaEscolhida = Console.ReadLine()!;

    if (bandasRegistradas.ContainsKey(bandaEscolhida))
    {
        double mediaBanda = bandasRegistradas[bandaEscolhida].Average();
        Console.Clear();
        Console.WriteLine($"A média da banda {bandaEscolhida} é: {mediaBanda}");
        Thread.Sleep(3000);
        ExibirOpcoesDoMenu();
    }
    else
    {
        Console.WriteLine("A banda escolhida não foi encontrada!");
        Console.WriteLine("Digite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
        ExibirOpcoesDoMenu();
    }
}

ExibirOpcoesDoMenu();
