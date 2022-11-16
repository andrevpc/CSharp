using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

// ============================== FUNÇÕES =================================

void Anos(int num) // Mostra todos os Jogos acima do ano <num>
{
    var Anos = read().Where(j => j.Ano > num);

    foreach (var item in Anos)
        Console.WriteLine($"{item.Nome} -- {item.Ano}");
}


void Notas(int num, int qtd) // Pega os <qtd> primeiros jogos com notas acima do <num>
{
    var Notas = read()
        .Where(x => x.Nota > num)
        .OrderByDescending(x => x.Nota)
        .Take(qtd);

    foreach (var item in Notas)
        Console.WriteLine($"{item.Nome} -- {item.Nota}");
}


void Info(string Nomegame) // Mostra todas as infos sobre o <Nomegame>
{
    var df = read();
    
    bool Existe = false;
    foreach (var x in df)
    { 
        if (x.Nome == Nomegame)
        {
            Console.WriteLine($"Jogo: {x.Nome}\nAno de Lançamento: {x.Ano}\nEmpresa: {x.Dono}\nNota: {x.Nota}");
            Existe = true;
            break;
        }
    }
    if (!Existe)
        Console.WriteLine("Jogo não encontrado!");
}


// ===================== CHAMAR FUNÇÕES ========================

// Anos(1990);
// Notas(90,5);
Info("Super Mario Galaxy");






// =========================== MANIPULAÇÃO DO ARQUIVO ===========================
IEnumerable<Jogos> read()
{
    StreamReader reader = new StreamReader("data/video_games.csv");

    var header = reader.ReadLine().Replace("\"", "").Split(",").ToList(); // Separa os headers

    int NomeJogo = header.IndexOf("Title");
    int NomeEmpresa = header.IndexOf("Metadata.Publishers");
    int AnoJogo = header.IndexOf("Release.Year");
    int Review = header.IndexOf("Metrics.Review Score");

    while (!reader.EndOfStream)
    {
        string[] jogo = reader.ReadLine().Replace("\"", "").Split(",");
        Jogos games = new Jogos();

        games.Nome = jogo[NomeJogo];
        games.Dono = jogo[NomeEmpresa];

        if (int.TryParse(jogo[Review], out int n))
            games.Nota = n;
        
        if (int.TryParse(jogo[AnoJogo], out n))
            games.Ano = n;

        yield return games;
    }
}
