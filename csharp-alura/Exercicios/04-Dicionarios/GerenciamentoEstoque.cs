// Exercício 4.2 — Gerenciamento de estoque
Dictionary<string, int> estoque = new Dictionary<string, int>();
estoque.Add("Garrafa", 10);
estoque.Add("Escova", 20);

string procurarProduto()
{
    Console.WriteLine("Digite o nome de um produto:");
    return Console.ReadLine();
}

int opcao;
do
{
    string produtoEscolhido = procurarProduto();

    if (estoque.ContainsKey(produtoEscolhido))
    {
        Console.WriteLine($"Produto: {produtoEscolhido}, Quantidade: {estoque[produtoEscolhido]}");
    }
    else
    {
        Console.WriteLine("Produto não encontrado.");
    }

    Console.Write("Digite '0' para parar ou qualquer número para continuar: ");
    opcao = int.Parse(Console.ReadLine());
}
while (opcao != 0);

Console.WriteLine("Parando de procurar...");
