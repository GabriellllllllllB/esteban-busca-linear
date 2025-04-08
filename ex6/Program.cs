class Program
{
    static void Main(string[] args)
    {
        Aluno[] alunos =
        {
            new Aluno { nome = "João", matricula = "123" },
            new Aluno { nome = "Maria", matricula = "456" },
            new Aluno { nome = "José", matricula = "789" }
        };
        string matriculaachada = "456";
        Aluno alunoachado = buscaralunom(alunos, matriculaachada);

        if (alunoachado != null)
        {
            Console.WriteLine($"aluno achado: {alunoachado.nome}, Matrícula: {alunoachado.matricula}");
        }
        else
        {
            Console.WriteLine("aluno não achado.");
        }
    }


    static Aluno buscaralunom(Aluno[] alunos, string matricula)
    {
        foreach (Aluno aluno in alunos)
        {
            if (aluno.matricula == matricula)
            {
                return aluno;
            }
        }
        return null;
    }
}