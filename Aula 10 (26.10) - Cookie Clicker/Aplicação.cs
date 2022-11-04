public class Aplicacao
{
    public static float Moedas { get; set; }

    public Maquina1 maquina1;
    public Maquina2 maquina2;
    public Maquina3 maquina3;
    public Maquina4 maquina4;
    public Maquina5 maquina5;

    public Aplicacao()
    {
        maquina1 = new Maquina1();
        maquina2 = new Maquina2();
        maquina3 = new Maquina3();
        maquina4 = new Maquina4();
        maquina5 = new Maquina5();
    }

    public void Menu()
    {
        Console.WriteLine($"0 para ganhar moedas e 1 para comprar maquinário\nVocê tem {Aplicacao.Moedas} moedas");
        ConsoleKeyInfo tecla;
        tecla = Console.ReadKey();
        if (tecla.Key == ConsoleKey.D0) //0
        {
            Aplicacao.Moedas = Aplicacao.Moedas + 10 + maquina1.Aumento() + maquina2.Aumento() + maquina3.Aumento();
        }
        else if (tecla.Key == ConsoleKey.D1) //1
        {
            Console.WriteLine($"Qual maquina você quer (1-5)?\nMaquina 1 custa: {maquina1.Preco} moedas e você tem: {maquina1.Qtde} maquinas\nMaquina 2 custa: {maquina2.Preco} moedas e você tem: {maquina2.Qtde} maquinas\nMaquina 3 custa: {maquina3.Preco} moedas e você tem: {maquina3.Qtde} maquinas\nMaquina 4 custa: {maquina4.Preco} moedas e você tem: {maquina4.Qtde} maquinas\nMaquina 5 custa: {maquina5.Preco} moedas e você tem: {maquina5.Qtde} maquinas\n");
            int opcao = Convert.ToInt16(Console.ReadLine());
            switch(opcao)
            {
                case 1:
                    if (Aplicacao.Moedas > maquina1.Preco)
                    {
                    maquina1.Compra();
                    Aplicacao.Moedas -= maquina1.Preco;
                    }
                    break;
                case 2:
                    if (Aplicacao.Moedas > maquina2.Preco)
                    {
                    maquina2.Compra();
                    Aplicacao.Moedas -= maquina2.Preco;
                    }
                    break;
                case 3:
                    if (Aplicacao.Moedas > maquina3.Preco)
                    {
                    maquina3.Compra();
                    Aplicacao.Moedas -= maquina3.Preco;
                    }
                    break;
                case 4:
                    if (Aplicacao.Moedas > maquina4.Preco)
                    {
                    maquina3.Compra();
                    Aplicacao.Moedas -= maquina4.Preco;
                    }
                    break;
                case 5:
                    if (Aplicacao.Moedas > maquina5.Preco)
                    {
                    maquina3.Compra();
                    Aplicacao.Moedas -= maquina5.Preco;
                    }
                    break;
            }
        }
    }
}