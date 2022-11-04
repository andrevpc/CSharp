public abstract class Player // Abstrata não pode ser estanciada sem uma herdeiras (aplicando as funções)
{
    public int Moeda { get; protected set; } = 1; // Protected: Só pode ser setada dentro da classe ou de suas herdeiras - é uma varialvel e o igual seta ele como padrâo
    public abstract bool Decidir(); // Abstrato: Todos tem, mas é diferente para cada // Se não colocar nada não pode dar override
    public virtual void Recebe(int valor) // Virtual: é o padrão se você não der um override, o void não retorna nada, serve para mudar alguma variavel
    {
        this.Moeda += valor;
    }
}