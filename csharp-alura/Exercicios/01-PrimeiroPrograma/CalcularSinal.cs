// Exercício 1 — Calcular Sinal
void calcularSinal(int num)
{
    if (num > 0)
    {
        Console.WriteLine("Positivo");
    }
    else if (num == 0)
    {
        Console.WriteLine("Zero");
    }
    else
    {
        Console.WriteLine("Negativo");
    }
}

calcularSinal(5);
calcularSinal(-1);
calcularSinal(0);
