using System; // Tudo conectado porque não tem gamespace, se criar para usa-lo deve usar o using

public static class Mundo // Estatico não pode ser estanciada, não terá vários mundos, apenas um (não precisa usar Cooperador c = new Cooperador para usar suas funções)
// Como se fosse uma biblioteca -> armazenado de funções
// Struct: variavel é de valor (fica armazenado lá, cópia, ou seja mais rápido) Classe: ponteiro para a memória
{
    public static Player[] Players { get; private set; } = new Player[1000]; // Criar uma lista de jogadores com 1000 players, Player[] é a variavel da classe que entra na lista de classes
    private static int index { get; set; } = 0;
    public static int Falidos { get; private set; } = 0; // Privado: só precisa ver e não mudar
    public static int TotalMoedas { get; private set; } = Mundo.Players.Length; // Não precisa usar this, pois só existe um mundo
    public static int Rodada { get; private set; } = 0;
    public static void Jogada()
    {
        Random r = new Random();
        // import random
        // random.randint(0, tamamnho da lista)
        Player jogador1, jogador2;
        while (true)
        {
            jogador1 = Mundo.Players[
                r.Next(Mundo.Players.Length)
                ];
            jogador2 = Mundo.Players[r.Next(Mundo.Players.Length)];
            if ((jogador1.Moeda > 0 && jogador2.Moeda > 0) && jogador1 != jogador2)
                break;
        }
        if (jogador1.Decidir() && jogador2.Decidir()) // Retorno bool não precisa colocar == true
        {
            // jogador1.Recebe(-1);
            // jogador1.Recebe(2);
            // =
            jogador1.Recebe(1);
            jogador2.Recebe(1);
            Mundo.TotalMoedas += 2;
        }
        else if (jogador1.Decidir() && !jogador2.Decidir())
        {
            jogador1.Recebe(-1);
            jogador2.Recebe(4);
            Mundo.TotalMoedas += 3;
        }
        else if (!jogador1.Decidir() && jogador2.Decidir())
        {
            jogador1.Recebe(4);
            jogador2.Recebe(-1);
            Mundo.TotalMoedas += 3;
        }
        else
        {
            jogador1.Recebe(0);
            jogador2.Recebe(0);
        }
        if (jogador1.Moeda == 0)
            Mundo.Falidos++;
        if (jogador2.Moeda == 0)
            Mundo.Falidos++;

        Mundo.Rodada += 1;
    }
    private static void addJogador(Player jogador)
    {
        Mundo.Players[Mundo.index] = jogador;
        Mundo.index++;
    }
    public static void GerarJogadores(
        int cooperadores, int trapaceiros, int copiadores)
    {
        if (cooperadores + trapaceiros + copiadores > Mundo.Players.Length)
            throw new Exception();
        for (int i =0; i < cooperadores; i++)
            Mundo.addJogador(new Cooperador());
        for (int i =0; i < trapaceiros; i++)
            Mundo.addJogador(new Trapaceiro());
        for (int i =0; i < copiadores; i++)
            Mundo.addJogador(new Copiador());
    }
}