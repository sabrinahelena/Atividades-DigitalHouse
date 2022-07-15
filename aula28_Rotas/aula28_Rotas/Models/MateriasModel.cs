namespace aula28_Rotas.Models
{
    public class MateriasModel
    {
        public string Materia { get; set; }
        public double NotaUm { get; set; }
        public double NotaDois { get; set; }
        public double NotaTres { get; set; }
        public double NotaQuatro { get; set; }
        public string Status { get; set; }
        public NotasModel Notas { get; set; }
    }
}
