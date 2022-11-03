// for(int i = 0; i < 2; i++)
// {
// Console.WriteLine($"Insira o tipo do animal {i+1}: ");
// string tip = Console.ReadLine();
// Console.WriteLine($"Insira o nome do animal {i+1}: ");
// string nom = Console.ReadLine();
// Animal.novoAnimal(tip, nom);
// }
// Console.WriteLine("Cachorros: "+ Animal.cachorro + "\nGatos: " + Animal.gato + "\nPeixes: " + Animal.peixe);

// public class Animal
// {
//     public static List<Animal> Animais = new List<Animal>();
//     private string Tipo { get; set; }
//     private string Nome { get; set; }
//     public static int cachorro = 0;
//     public static int peixe = 0;
//     public static int gato = 0;

//     private Animal(string tip, string nom)
//     {
//         this.Nome = nom;
//         if ((tip != "Gato" && tip != "Cachorro") || tip == "Peixe")
//         {
//             this.Tipo = "Peixe";
//             peixe += 1;
//         }
//         else if (tip == "Gato")
//         {
//             this.Tipo = tip;
//             gato += 1;
//         }
//         else
//         {
//             this.Tipo = tip;
//             cachorro += 1;
//         }
//     }
//     static public Animal novoAnimal(string tip, string nom) => new Animal(tip, nom);
// }