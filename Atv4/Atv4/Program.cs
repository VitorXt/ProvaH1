using System;

public class Program
{
    public static void Main(string[] args)
    {
        // Ler a altura da pessoa
        Console.Write("Digite a altura da pessoa (em metros): ");
        double altura = double.Parse(Console.ReadLine());

        // Ler o sexo da pessoa
        Console.Write("Digite o sexo da pessoa (M para masculino e F para feminino): ");
        char sexo = char.Parse(Console.ReadLine());

        // Calcular o peso ideal da pessoa de acordo com o sexo
        double pesoIdeal;
        if (char.ToLower(sexo) == 'M')
        {
            pesoIdeal = (72.7 + altura) - 58;
        }
        else if (char.ToLower(sexo) == 'F')
        {
            pesoIdeal = (62.1) - 44.7;
        }
        else
        {
            Console.WriteLine("Sexo inválido.");
            return;
        }
        // Escrever o peso ideal da pessoa
        Console.WriteLine("O peso ideal da pessoa é " + pesoIdeal + " kg.");
    }
}
