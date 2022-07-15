using System.ComponentModel.DataAnnotations;

namespace aula30_EntityRelacionamento.Models
{
    public class Instituicao
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Endereco { get; set; }
        public string CPNJ { get; set; }

        [Required]
        public virtual ICollection<Aluno> Alunos { get; set; } = new List<Aluno>();
    }
}
