public class Player
{
    protected bool lastMove {get;set;}
    public int Moedas {get;set;}
    public abstract bool Decide();
    public virtual void Recebe(bool resposta)();
}

public class Colaborador : Player
{
    public override bool Decide() => true;
}

public class Trapaceiro : Player
{
    public override bool Decide() => false;
}

public class Remorse : Player
{
    public override bool Decide() => lastMove;
    public override void Recebe(bool resposta)
    {
        lastMove = resposta;
    }
    public class Copiador : Player
    {
        
    }
}