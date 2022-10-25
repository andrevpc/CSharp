public class Curso
{
    public int Codigo { get; set; }
    public string NomeDoCurso { get; set; }
    public int CargaHoraria { get; set; }

    public Curso(int cod, string nome, int cargH)
    {
        this.Codigo = cod;
        this.NomeDoCurso = nome;
        this.CargaHoraria = cargH;
    }
}