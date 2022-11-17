List<float> Notas = new List<float>();
List<float> Pesos = new List<float>(){3,3,4};

for (int i = 0; i < 3; i++)
{
    Console.WriteLine($"Insira a nota {i+1}");
    float nota = float.Parse(Console.ReadLine());
    Notas.Add(nota);
}

Console.WriteLine("Qual média você deseja aplicar? (1 - Aritmética | 2 - Ponderada(3,3,4) | 3 - Harmônica): ");
int opcao = int.Parse(Console.ReadLine());

switch(opcao)
{
    case 1:
        Console.WriteLine($"A média das notas é: {MediaAr(Notas)}");
        break;
    case 2:
        Console.WriteLine($"A média das notas é: {MediaPon(Notas)}");
        break;
    case 3:
        Console.WriteLine($"A média das notas é: {MediaHar(Notas)}");
        break;
    default:
        Console.WriteLine("Opção Inválida!");
        break;
}

float MediaAr(List<float> n) => n.Sum()/n.Count();

float MediaPon(List<float> n)
{
    float soma = 0;
    for(int i = 0; i < n.Count(); i++)
    {
        soma += n[i] * Pesos[i];
    }
    return soma/Pesos.Sum();
}

float MediaHar(List<float> n)
{
    float soma = 0;
    for(int i = 0; i < n.Count(); i++)
    {
        soma += 1/n[i];
    }
    return n.Count() / soma;
}