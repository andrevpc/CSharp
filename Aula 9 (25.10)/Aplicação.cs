public class Aplicacao
{

    List<Aluno> Alunos = new List<Aluno>();
    List<Curso> Cursos = new List<Curso>();


    
    public Aluno getAlunoByID(int id)
    {
        foreach (var aluno in this.Alunos)
        {
            if (aluno.Matricula == id)
            {
                return aluno;
            }
        }
        throw new Exception();
    }

    public Aluno novoAluno()
    {
        Console.WriteLine("Insira o nome do aluno: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira a matricula do aluno: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o código do curso que o aluno está cursando: ");
        int codigoCurso = int.Parse(Console.ReadLine());

        return new Aluno(nome, matricula, codigoCurso);
    }

    public Curso novoCurso()
    {
        Console.WriteLine("Insira o nome do curso: ");
        string nomeDoCurso = Console.ReadLine();
        Console.WriteLine("Insira a carga horaria do curso: ");
        int cargaHoraria = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o código do curso: ");
        int codigo = int.Parse(Console.ReadLine());

        return new Curso(codigo, nomeDoCurso, cargaHoraria);
    }

    //Novo aluno
    
    // Alunos do curso by id

    public void Menu()
    {


        switch(opcao)
        {
            case 1:
                Cursos.add(novoCurso());
                break;
        }
    }

}