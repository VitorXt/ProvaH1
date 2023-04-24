using System;
public class Program
{
    public static void Main(string[] args)
    {
        // Ler a hora de início do jogo
        Console.Write("Digite a hora de início do jogo (hora:minuto): ");
        string[] inicio = Console.ReadLine().Split(':');
        int HoraInicio = int.Parse(inicio[0]);
        int MinutoInicio = int.Parse(inicio[1]);
        // Ler a hora de término do jogo
        Console.Write("Digite a hora de término do jogo (hora:minuto): ");
        string[] fim = Console.ReadLine().Split(':');
        int HoraFim = int.Parse(fim[0]);
        int MinutoFim = int.Parse(fim[1]);
        // Calcular a duração do jogo em minutos
        int DuracaoMinutos = (HoraFim * 60 + MinutoFim) - (HoraInicio * 60 + MinutoInicio);
        // Tratar caso o jogo tenha ultrapassado 24 horas
        if (DuracaoMinutos < 0)
        {
            DuracaoMinutos += 1440;
        }
        // Calcular a duração do jogo em horas e minutos
        int DuracaoHoras = DuracaoMinutos / 60;
        DuracaoMinutos = DuracaoMinutos % 60;
        // Escrever a duração do jogo
        Console.WriteLine("A duração do jogo foi de " + DuracaoHoras + " horas e " + DuracaoMinutos + " minutos.");
    }
}
