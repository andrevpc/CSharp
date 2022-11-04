public static class Aplicacao
{
    public static bool Running { get; set; } = true;
    static List<Aluno> Alunos = new List<Aluno>();
    static List<Curso> Cursos = new List<Curso>();

    public static void Menu(int opcao)
    {
        switch(opcao)
        {
            case 1:
                Cursos.Add(novoCurso());
                break;
            case 2:
                foreach (var curso in Aplicacao.Cursos)
                {
                    Console.WriteLine(curso.NomeDoCurso);
                }
                break;
            case 3:
                Alunos.Add(novoAluno());
                break;
            case 4:
                novaNota();
                break;
            case 5:
                estatisticas();
                break;
            case 6:
                Running = false;
                break;
        }
    }
    

    public static Aluno getAlunoByID(int id)
    {
        foreach (var aluno in Aplicacao.Alunos)
        {
            if (aluno.Matricula == id)
            {
                return aluno;
            }
        }
        throw new Exception();
    }

    public static Aluno novoAluno()
    {
        Console.WriteLine("Insira o nome do aluno: ");
        string nome = Console.ReadLine();
        Console.WriteLine("Insira a matricula do aluno: ");
        int matricula = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o código do curso que o aluno está cursando: ");
        int codigoCurso = int.Parse(Console.ReadLine());

        return new Aluno(nome, matricula, codigoCurso);
    }

    public static Curso novoCurso()
    {
        Console.WriteLine("Insira o nome do curso: ");
        string nomeDoCurso = Console.ReadLine();
        Console.WriteLine("Insira a carga horaria do curso: ");
        int cargaHoraria = int.Parse(Console.ReadLine());
        Console.WriteLine("Insira o código do curso: ");
        int codigo = int.Parse(Console.ReadLine());

        return new Curso(codigo, nomeDoCurso, cargaHoraria);
    }

    public static void novaNota()
    {
        Console.WriteLine("Insira o código do curso: ");
        int codigoCurso = int.Parse(Console.ReadLine());

        foreach (var aluno in Aplicacao.Alunos)
        {
            if (aluno.CodigoCurso == codigoCurso)
            {
                Console.WriteLine($"Insira a nota do {aluno.Nome}: ");
                int nota = int.Parse(Console.ReadLine());
                aluno.Nota = nota;
            }
        }
    }

    public static void estatisticas()
    {
        Console.WriteLine("Insira o código do curso: ");
        int codigoCurso = int.Parse(Console.ReadLine());
        float soma = 0;
        int cursando = 0;
        foreach (var aluno in Aplicacao.Alunos)
        {
            if (aluno.CodigoCurso == codigoCurso)
            {
                soma += aluno.Nota;
                cursando += 1;
            }
        }
        float media = soma/cursando;
        Console.WriteLine(media);
    }
}