// List<Jogador> Time1 = new List<Jogador>();


// for (int j = 0; j < 11; j++)
// {
//     Console.Clear();

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
//     Time1.Add(Player);
// }

// for (int k = 0; k<Time1.Count(); k++)
//     Time1[k].MostrarTudo();

// public class Jogador
// {
//     private int Id { get; set; }
//     private string Nome { get; set; }
//     private string Posicao { get; set; }
//     private string Apelido { get; set; }
//     private string DataNascimento { get; set; }
//     private int Numero { get; set; }
//     private double Qualidade { get; set; }
//     private int CartaoAmarelo { get; set; }
  
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

//     public bool Condicao()
//     {
//         if (this.CartaoAmarelo >=3)
//             return false;
//         else    
//             return true;
//     }

//     public void Mostrar()
//     {
//         string cond = this.Condicao() ? "Tá pra jogo" : "Fora do jogo"; // <condicao> ? caso verdadeiro : caso falso
//         Console.WriteLine($"{this.Posicao}: {this.Numero} - {this.Nome} ({this.Apelido}) - {this.DataNascimento} Condição: {cond} Qualidade: {this.Qualidade}\n");
//     }

//     public void MostrarTudo()
//     {
//         string cond = this.Condicao() ? "Tá pro Game" : "Fora do jogo"; // <condicao> ? caso verdadeiro : caso falso
//         Console.WriteLine($"Id: {this.Id}\nPosição: {this.Posicao}\nNúmero: {this.Numero}\nNome: {this.Nome}\nApelido: {this.Apelido}\nData de Nascimetno: {this.          DataNascimento}\nCartões: {this.CartaoAmarelo}\nCondição: {cond}\nQualidade: {this.Qualidade}\n");
//     }

//     public void AplicarCartao(int numero)
//     {
//         this.CartaoAmarelo += numero;
//     }

//     public void AplicarCartaoVermelho()
//     {
//         this.CartaoAmarelo = 3;
//     }

//     public void CumprirSuspensao()
//     {
//         this.CartaoAmarelo = 0;
//     }

//     public void SofrerLesao()
//     {
//         Random randNum = new Random();
//         int valor = randNum.Next(100);
        
//         if (valor<=5)
//             this.Qualidade -= (this.Qualidade * 0.15);

//         else if(valor<=14 && valor>5)
//             this.Qualidade -= (this.Qualidade * 0.10);

//         else if(valor<=29 && valor>14)
//             this.Qualidade -= (this.Qualidade * 0.05);

//         else if(valor<=59 && valor>29)
//             this.Qualidade -= 2;
        
//         else
//             this.Qualidade -= 1;
//     }

//         public void Treino()
//     {
//         Random randNum = new Random();
//         int valor = randNum.Next(100);
        
//         if (valor<=5)
//             this.Qualidade += (this.Qualidade * 0.15);

//         else if(valor<=14)
//             this.Qualidade += (this.Qualidade * 0.10);

//         else if(valor<=29)
//             this.Qualidade += (this.Qualidade * 0.05);

//         else if(valor<=59)
//             this.Qualidade += 2;
        
//         else
//             this.Qualidade += 1;
//     }
// }
