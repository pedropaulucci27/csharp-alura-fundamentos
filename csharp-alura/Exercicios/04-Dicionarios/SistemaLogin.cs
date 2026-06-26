// Exercício 4.4 — Sistema de login
Dictionary<string, string> nomeUsuarios = new Dictionary<string, string>();
nomeUsuarios.Add("Pedro", "12345");
nomeUsuarios.Add("Mari", "6789");

bool usuarioCorreto = false;
do
{
    Console.WriteLine("Digite o nome de usuário: ");
    string nome = Console.ReadLine().Trim();

    if (nomeUsuarios.ContainsKey(nome))
    {
        usuarioCorreto = true;

        bool senhaCorreta = false;
        do
        {
            Console.WriteLine($"{nome}, digite sua senha: ");
            string senha = Console.ReadLine();

            if (nomeUsuarios[nome] == senha)
            {
                senhaCorreta = true;
                Console.WriteLine("Senha correta!");
                Thread.Sleep(1000);
                Console.WriteLine("Logando...");
                Thread.Sleep(2000);
                Console.WriteLine("Usuário logado!");
            }
            else
            {
                Console.WriteLine("Senha incorreta, tente novamente!");
            }
        }
        while (!senhaCorreta);
    }
    else
    {
        Console.WriteLine("Usuário não encontrado, tente novamente!");
    }
}
while (!usuarioCorreto);
