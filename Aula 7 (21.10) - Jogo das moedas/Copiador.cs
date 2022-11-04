public class Copiador : Player
{
    private bool vouAjudar { get; set; } = true; // Privado: Só ele vai usar, propriedades privadas começam com minúsculo
    public override bool Decidir()
    {
        return this.vouAjudar;
    }
    public override void Recebe(int valor)
    {
        this.vouAjudar = valor > 0;
        base.Recebe(valor);
    }
}