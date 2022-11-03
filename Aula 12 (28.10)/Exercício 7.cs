Livro livro = new Livro("MM", 200, 100);
livro.verificarProgresso();
livro.LerPaginas(50);
livro.verificarProgresso();

public class Livro
{
    public string Titulo { get; private set; }
    public int QtdPaginas { get; private set; }
    public int PaginasLidas { get; private set; }
    public Livro(string tit, int qp, int pl)
    {
        this.Titulo = tit;
        this.QtdPaginas = qp;
        this.PaginasLidas = pl;
    }
    public void verificarProgresso()
    {
        Console.WriteLine($"Você já leu {this.PaginasLidas*100/this.QtdPaginas}%");
    }

    public void LerPaginas(int pag)
    {
        this.PaginasLidas += pag;
    }

}