while (Aplicacao.Running)
{
    Console.WriteLine("1- Cadastrar Curso\n2- Listar cursos\n3- Cadastrar Alunos\n4- Dar notas\n5- Estatisticas\n6- Sair");
    int opcao = int.Parse(Console.ReadLine());
    Aplicacao.Menu(opcao);
}