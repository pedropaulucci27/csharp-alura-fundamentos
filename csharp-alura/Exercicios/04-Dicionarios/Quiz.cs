// Exercício 4.3 — Quiz de perguntas e respostas
Dictionary<string, List<string>> perguntas = new Dictionary<string, List<string>>();

perguntas.Add("Quantos ossos tem o corpo humano (bebe ou adulto)? ", new List<string> { "206 ossos", "270 ossos" });
perguntas.Add("Cite um país que faz fronteira com o Brasil: ", new List<string> { "Guiana Francesa", "Suriname", "Guiana", "Venezuela", "Colombia", "Peru", "Bolivia", "Paraguai", "Argentina", "Uruguai" });

foreach (string pergunta in perguntas.Keys)
{
    bool correto = false;
    do
    {
        Console.WriteLine(pergunta);
        string resposta = Console.ReadLine();

        if (perguntas[pergunta].Contains(resposta))
        {
            Console.WriteLine("Resposta correta!");
            correto = true;
        }
        else
        {
            Console.WriteLine("Tente novamente!");
        }
    }
    while (!correto);
}
