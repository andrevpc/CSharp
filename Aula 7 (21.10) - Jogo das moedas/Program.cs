Mundo.GerarJogadores(500, 250, 250);

while (Mundo.Rodada < 50000)
{
    // Deixamos o get publico para poder ver Rodada
    Mundo.Jogada();
}
Console.WriteLine($"Rodada: {Mundo.Rodada}");
Console.WriteLine($"Falidos: {Mundo.Falidos}");
Console.WriteLine($"Total de Moedas: {Mundo.TotalMoedas}");