public abstract class Maquina
{
    public float XAumento { get; protected set; }
    public float Preco { get; protected set; }
    public int Qtde { get; protected set; }
    public virtual float Aumento()
    {
        return this.XAumento * this.Qtde;
    }
    public virtual void Compra()
    {
        this.Qtde += 1;
    }
}

public class Maquina1 : Maquina
{
    public Maquina1()
    {
        this.XAumento = 1.1F;
        this.Preco = 10;
    }
}

public class Maquina2 : Maquina
{
    public Maquina2()
    {
        this.XAumento = 1.2F;
        this.Preco = 20;
    }
}

public class Maquina3 : Maquina
{
    public Maquina3()
    {
        this.XAumento = 1.3F;
        this.Preco = 30;
    }
}

public class Maquina4 : Maquina
{
    public Maquina4()
    {
        this.XAumento = 1.4F;
        this.Preco = 40;
    }
}

public class Maquina5 : Maquina
{
    public Maquina5()
    {
        this.XAumento = 1.5F;
        this.Preco = 50;
    }
}