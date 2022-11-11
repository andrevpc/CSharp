// Operadores, classes(Abstração, Encapsulamento, Herança, Polimorfismo), Linq, leitura de arquivos, genéricos
for(int i =0; i<int.Parse(args[1]); i++)
    Console.WriteLine(args[0]); // Coloca o argumento no console (dotnet run "Ola mundo")

Vacinas vacinas = Vacinas.Pfizer;

if(vacinas == Vacinas.Pfizer)

// || é operação bit a bit (binario)
switch(vacinas)
{

}

public enum Key //Pega o número ao ser istanciada (mais fácil de lembro doq o número)
{
    Alt,
    Ctrl,
    A,
    B,
    C,
    D,
    N0,
    N1,
}

public enum Vacinas : byte // Byte para gastar menos dados (byte vai até 255)
{
    Coronavac,
    Astrazeneca,
    Pfizer,
    Janssen
}