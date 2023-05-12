Console.Clear();

Console.WriteLine("   Hora de multiplicar   ");

Console.WriteLine();

Console.Write("Digite o número: ");

int n1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Verificar se é multiplo de: ");

int n2 = Convert.ToInt32(Console.ReadLine());

if (n1 % n2 == 0)
{
    Console.WriteLine($"\n{n1} é múltiplo de {n2}");
}
else
{
    Console.WriteLine($"\n{n1} não é múltiplo de {n2}");
}

