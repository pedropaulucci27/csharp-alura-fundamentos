// Exercício 4.5 — Média de vendas de carros
Dictionary<string, List<int>> vendasCarros = new Dictionary<string, List<int>>
{
    { "Bugatti Veyron", new List<int> { 10, 15, 12, 8, 5 } },
    { "Koenigsegg Agera RS", new List<int> { 2, 3, 5, 6, 7 } },
    { "Lamborghini Aventador", new List<int> { 20, 18, 22, 24, 16 } },
    { "Pagani Huayra", new List<int> { 4, 5, 6, 5, 4 } },
    { "Ferrari LaFerrari", new List<int> { 7, 6, 5, 8, 10 } }
};

Console.WriteLine("Digite o nome de um carro: ");
string nomeCarro = Console.ReadLine();

double calcularMedia(string nome)
{
    return vendasCarros[nome].Average();
}

if (vendasCarros.ContainsKey(nomeCarro))
{
    Console.WriteLine($"Média: {calcularMedia(nomeCarro)}");
}
else
{
    Console.WriteLine("Carro não encontrado!");
}
