class Counter
{
    static void Main(string[] args)
    {
        Console.WriteLine("por favor escriva una frase o palabra:");
        string name = Console.ReadLine() ?? string.Empty;

        int contadorVocales = 0;

        foreach (char c in name)
        {
            if ("aeiou".Contains(c))
            {
                contadorVocales++;
            }
        }

        Console.WriteLine("Numero de vocales: " + contadorVocales);
    }
}