// click 0 = soma
// click c = compra
// mostrar quantidade de cada e preço
public static class Aplicacao
{
    public static void Menu()
    {
        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.D0) //0
        {
            ;
        }
        else if (tecla.Key == ConsoleKey.D1) //1
        {
            Console.WriteLine("Qual maquina você quer?");
            int opcao = int.Parse(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                    break;
            }
        }
    }
}