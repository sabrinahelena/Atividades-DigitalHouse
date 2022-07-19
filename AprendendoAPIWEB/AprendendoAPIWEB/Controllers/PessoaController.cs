using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AprendendoAPIWEB.Controllers
{

    // Tabelas = Models
    public class Pessoa
    {

        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }

    }

    // Banco de dados = Contexts
    public class DbResidencia
    {
        public List<Pessoa> Pessoas { get; set; } = new List<Pessoa>
            {
                new Pessoa {
                    Id = 1,
                    Nome = "Willian",
                    Sobrenome = "Sant Anna"
                },
                new Pessoa {
                    Id = 2,
                    Nome = "Marcos",
                    Sobrenome = "Antonio"
                }
            };
    }


    [Route("api/[controller]")]
    [ApiController]
    public class PessoaController : ControllerBase
    {
        /*
            Métodos Http

            GET     => Pedir um valor.
            POST    => Publicar um valor.
            DELETE  => Remover um valor.
            PUT     => Substituir um valor.
            PATCH   => Alterar um valor.
         */

        /*
            Aluna aluna = new Aluna() {
                NomeCompleto = Lany Silva,
                Idade = 18
            }

            Patch - Alterar um valor.
            aluna.Idade = 22;

            Put - Substituir um valor.
            aluna = new Aluna {
                NomeCompleto = Willian Sant Anna,
                Idade = 31
            }
         */

        private DbResidencia dbResidencia = new DbResidencia();

        [HttpGet]
        public Pessoa[] AcessarPessoas()
        {
            return dbResidencia.Pessoas.ToArray();
        }


        [HttpGet("{Id}")]
        public Pessoa AcessarPessoaPelaId(int Id)
        {
            Pessoa Resultado = new Pessoa();

            foreach (Pessoa pessoa in dbResidencia.Pessoas)
            {
                if (pessoa.Id == Id)
                {
                    Resultado = pessoa;
                }
            }

            return Resultado;
        }

        [HttpPost]
        public Pessoa CadastrarPessoa(Pessoa novaPessoa)
        {
            dbResidencia.Pessoas.Add(novaPessoa);

            return novaPessoa;
        }

        [HttpDelete("{Id}")]
        public Pessoa DeletarPessoa(int Id)
        {
            Pessoa PessoaDeletada = new Pessoa();

            foreach (Pessoa pessoa in dbResidencia.Pessoas)
            {
                if (pessoa.Id == Id)
                {
                    PessoaDeletada = pessoa;
                    dbResidencia.Pessoas.Remove(PessoaDeletada);
                }
            }

            return PessoaDeletada;
        }
    }
}
