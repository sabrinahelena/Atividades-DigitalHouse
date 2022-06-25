using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace aula13_enum_dictionary
{
    internal class Escola
    {
        private readonly Dictionary<int, Aluno> _matriculados = new();
        private int _matriculaAtual = 0;

        public void CadastrarAluno()
        {
            Console.WriteLine("Digite o nome do aluno para o cadastro: ");
            string nomeAluno = Console.ReadLine();

            Console.WriteLine("Digite o sobrenome do aluno para o cadastro: ");
            string sobrenome = Console.ReadLine();

            Console.WriteLine("Digite o telefone do aluno para o cadastro: ");
            int telefone = int.Parse(Console.ReadLine());

            var aluno = new Aluno()
            {
                Nome = nomeAluno,
                Sobrenome = sobrenome,
                Telefone = telefone,
                Matricula = ++_matriculaAtual
            };

            _matriculados.Add(aluno.Matricula, aluno);
        }

        public void RemoverAluno()
        {
            Console.WriteLine("Digite a matrícula que será removida: ");
            int matricula = int.Parse(Console.ReadLine());

            _matriculados.Remove(matricula);
        }

        public void ListarTodasMatriculasEAlunos()
        {
            foreach (var matriculasEAlunos in _matriculados)
            {
                Console.WriteLine($"{matriculasEAlunos.Key}: {matriculasEAlunos.Value.Nome} {matriculasEAlunos.Value.Sobrenome}");
            }
        }
    }
}
