namespace aula13_enumerador
{
    internal enum Erro
    {
        Ok = 200,
        RedirecionamentoPermanente = 301,
        RedirecionamentoTemporario = 302,
        NaoEncontrado = 404,
        NaoAutorizado = 405,
        ServidorIndisponivel = 503,
        TempoEsgotado = 504
    }

    internal class Program
    {
        private static void Main(string[] args)
        {
            // Formatos possíveis: "G", "D", "X", "F"
            foreach (var valor in Enum.GetValues<Erro>())
                Console.WriteLine($"{valor}: {valor:D}"); //:D valor decimal, imprime o número
        }
    }
}