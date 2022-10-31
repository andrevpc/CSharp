using System;

Console.WriteLine("Insira a altura: ");
int alt = int.Parse(Console.ReadLine());
Console.WriteLine("Insira a base: ");
int bas = int.Parse(Console.ReadLine());

Retangulo retangulo = new Retangulo(alt, bas);
retangulo.VerArea();

public class Retangulo
{
    public int Altura { get; set; }
    public int Base { get; set; }
    public Retangulo(int alt, int bas)
    {
        this.Altura = alt;
        this.Base = bas;
    }
    public float Area()
    {
        return this.Altura * this.Base;
    }
    public void VerArea()
    {
        Console.WriteLine("Área: "+this.Area());
    }
    public void Propriedades()
    {
        Console.WriteLine("Altura: "+this.Altura);
        Console.WriteLine("Base: "+this.Base);
        Console.WriteLine("Área: "+this.Area());
    }
}
