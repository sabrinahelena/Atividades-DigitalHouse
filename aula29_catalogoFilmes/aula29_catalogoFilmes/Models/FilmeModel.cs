namespace aula29_catalogoFilmes.Models
{
    public class FilmeModel
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public DateTime DataLancamento { get; set; }
        public int HorasDuracao { get; set; }
    }
}
