// using System;

// for (int j = 0; j < 3; j++)
// {
//     ListarPessoas.Adicionar(ListarPessoas.Criar());
// }

// ListarPessoas.Maior();

// public class Pessoa
// {
//     public int Idade { get; set; }
//     public string Nome  { get; set; }

//     public Pessoa(int ida, string nome)
//     {
//         this.Idade = ida;
//         this.Nome = nome;
//     }
//     public virtual void ExibirDados()
//     {
//         Console.WriteLine(this.Idade);
//         Console.WriteLine(this.Nome);
//     }
// }

// public static class ListarPessoas
// {
//     public static List<Pessoa> pessoas = new List<Pessoa>();
//     public static Pessoa MaisVelho = new Pessoa(0, "");
//     public static Pessoa Criar()
//     {
//         Console.WriteLine("Insira o nome da pessoa: ");
//         string nome = Console.ReadLine();
//         Console.WriteLine("Insira a idade da pessoa: ");
//         int ida = int.Parse(Console.ReadLine());

//         return new Pessoa(ida, nome);
//     }
//     public static void Adicionar(Pessoa pes)
//     {
//         pessoas.Add(pes);
//     }
//     public static void Maior()
//     {
//         foreach (var p in pessoas)
//         {
//             if (p.Idade >= MaisVelho.Idade)
//                 MaisVelho = p;
//         }
//         Console.WriteLine(MaisVelho.Nome);
//     }
// }