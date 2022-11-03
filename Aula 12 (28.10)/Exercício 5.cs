// // List<Jogador> Time1 = new List<Jogador>();
// Time sao = new Time("São Paulo", "Trikas", "25 de janeiro de 1930");
// Time fla = new Time("Flamengo", "Mengo", "17 de novembro de 1895");

// for (int j = 0; j < 46; j++)
// {
//     Console.Clear();
//     Console.WriteLine(j<23 ? "São Paulo" : "Flamengo");
//     Console.Write($"Digite o ID do {j+1}° Jogador: ");
//     int IDUser = int.Parse(Console.ReadLine() ?? "0");

//     Console.Write($"Digite o Nome do Jogador: ");
//     string NomeUser = Console.ReadLine() ?? "Desconhecido";

//     Console.Write($"Digite a Posição do {NomeUser}: ");
//     string PosicaoUser = Console.ReadLine() ?? "Desconhecido";

//     Console.Write($"Digite o Apelido do {NomeUser}: ");
//     string ApelidoUser = Console.ReadLine() ?? "Desconhecido";

//     Console.Write($"Digite a Data de Nascimento do {NomeUser}: ");
//     string DataUser = Console.ReadLine() ?? "Desconhecido";

//     Console.Write($"Digite o Número do {NomeUser}: ");
//     int NumUser = int.Parse(Console.ReadLine() ?? "0");

//         Console.Write($"Digite a qualidade do {NomeUser}: ");
//     double QualidadeUser = int.Parse(Console.ReadLine() ?? "0");

//     Console.Write($"Digite a Quantidade de Cartões Amarelos o {NomeUser} recebeu: ");
//     int AmareloUser = int.Parse(Console.ReadLine() ?? "0");

//     Jogador Player = new Jogador(IDUser, NomeUser, PosicaoUser, ApelidoUser, DataUser, NumUser, QualidadeUser, AmareloUser);
//     if (j<23)
//         sao.Plantel.Add(Player);
//     else
//         fla.Plantel.Add(Player);
// }

// sao.RelacionarJogadores(sao.Plantel);
// fla.RelacionarJogadores(fla.Plantel);
// public class Jogador
// {
//     public int Id { get; set; }
//     public string Nome { get; set; }
//     public string Posicao { get; set; }
//     public string Apelido { get; set; }
//     public string DataNascimento { get; set; }
//     public int Numero { get; set; }
//     public double Qualidade { get; set; }
//     public int CartaoAmarelo { get; set; }
  
//     public Jogador(int ID, string NOME, string POSICAO, string APELIDO, string DATANASCIMENTO, int NUMERO, double QUALIDADE, int CARTAOAMARELO)
//     {
//         this.Id = ID;
//         this.Nome = NOME;
//         this.Posicao = POSICAO;
//         this.Apelido = APELIDO;
//         this.DataNascimento = DATANASCIMENTO;
//         this.Numero = NUMERO;
//         this.Qualidade = QUALIDADE;
//         this.CartaoAmarelo = CARTAOAMARELO;

//         if (QUALIDADE > 100)
//             this.Qualidade = 100;

//         else if (Qualidade < 0) 
//             this.Qualidade = 0;
        
//         else
//             this.Qualidade = QUALIDADE;

//     }
// }

// public class Time
// {
//     public string Nome { get; set; }
//     public string Apelido { get; set; }
//     public string Fundacao { get; set; }
//     public List<Jogador> Plantel = new List<Jogador>();
//     public List<Jogador> Relacionados = new List<Jogador>();
//     public Time(string nom, string ape, string fun)
//     {
//         this.Nome = nom;
//         this.Apelido = ape;
//         this.Fundacao = fun;
//     }
//     // public void RelacionarJogadores(List<Jogador> jogadores)
//     // {
//     //     List<Jogador> Relacionados = jogadores.OrderByDescending(o=>o.Qualidade).ToList();
//     //     foreach(var jog in Relacionados)
//     //         Console.WriteLine(jog.Nome);
//     // }
//     // public void RelacionarJogadores(List<Jogador> jogadores)
//     // {
//     //     List<Jogador> Relacionados = jogadores.OrderByDescending(o=>o.Qualidade).ToList();
//     //     for (int i = 0; i <18; i++)
//     //     {
//     //         if (i<11)
//     //             Console.WriteLine("Titular"+Relacionados[i].Nome);
//     //         else
//     //             Console.WriteLine("Reserva"+Relacionados[i].Nome);
//     //     }
//     // }
//     public void RelacionarJogadores(List<Jogador> jogadores)
//     {
//         List<Jogador> atacante = new List<Jogador>();
//         List<Jogador> meioCampo = new List<Jogador>();
//         List<Jogador> defensor = new List<Jogador>();
//         List<Jogador> goleiro = new List<Jogador>();
//         List<Jogador> Relacionados = jogadores.OrderByDescending(o=>o.Qualidade).ToList();
//         foreach(var jog in Relacionados)
//         {
//             if (jog.Posicao == "ATA" && atacante.Count() < 5)
//             {
//                 atacante.Add(jog);
//             }
//             else if (jog.Posicao == "MEI" && meioCampo.Count() < 5)
//             {
//                 meioCampo.Add(jog);
//             }
//             else if (jog.Posicao == "DEF" && defensor.Count() < 4)
//             {
//                 defensor.Add(jog);
//             }
//             else if (jog.Posicao == "GOL" && goleiro.Count() < 4)
//             {
//                 goleiro.Add(jog);
//             }
//         }
//         List<Jogador> RelacionadosPorPosicao = new List<Jogador>();
//         RelacionadosPorPosicao.Concat(atacante)
//                               .Concat(defensor)
//                               .Concat(meioCampo)
//                               .Concat(goleiro);
//         foreach(var i in RelacionadosPorPosicao)
//         {
//             Console.WriteLine("Nome: "+i.Nome+"  Qualidade: "+i.Qualidade);
//         }
//     }
// }