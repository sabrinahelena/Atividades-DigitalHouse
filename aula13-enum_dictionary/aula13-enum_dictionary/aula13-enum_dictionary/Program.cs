namespace aula13_enum_dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Escola escola = new Escola();

            escola.CadastrarAluno();
            escola.CadastrarAluno();
            escola.CadastrarAluno();
            escola.ListarTodasMatriculasEAlunos();

            escola.RemoverAluno();
            escola.ListarTodasMatriculasEAlunos();
        }
    }
}