public class Aluno
{
    public int CodigoCurso { get; set; }
    public string Nome { get; set; }
    public int Matricula { get; set; }
    public int Nota { get; set; }
    public Aluno(string nom, int matr, int cod)
    {
        this.Nome = nom;
        this.Matricula = matr;
        this.CodigoCurso = cod;
    }
}