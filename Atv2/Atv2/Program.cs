using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[8];

        for (int i = 0; i < 8; i++)
        {
            Console.Write($"Digite o nome do {i + 1}º participante: ");
            nomes[i] = Console.ReadLine();
        }

        string[] AmigosSecretos = nomes.ToArray();
        bool Sorteio = false;

        while (!Sorteio)
        {
            Shuffle(AmigosSecretos);
            Sorteio = true;
            for (int i = 0; i < nomes.Length; i++)
            {
                if (AmigosSecretos[i] == nomes[i])
                {
                    Sorteio = false;
                    break;
                }
            }
        }

        Console.WriteLine(" ");
        for (int i = 0; i < nomes.Length; i++)
        {
            Console.WriteLine($"{nomes[i]} tirou {AmigosSecretos[i]} como amigo secreto.");
        }
    }

    static void Shuffle<T>(T[] array)
    {
        Random random = new Random();
        for (int i = array.Length - 1; i >= 1; i--)
        {
            int j = random.Next(i + 1);
            T temp = array[j];
            array[j] = array[i];
            array[i] = temp;
        }
    }
}