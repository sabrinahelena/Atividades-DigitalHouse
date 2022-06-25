int quilometrosPercorridosPeloVeiculo;
const float milhasPorKm = 0.621371f; //utilizei constante pois é um valor fixo. 
float conversao;

Console.WriteLine("Digite por inteiro quantos quilometros foram percorridos pelo seu veículo: ");
quilometrosPercorridosPeloVeiculo = Convert.ToInt32(Console.ReadLine());

conversao = quilometrosPercorridosPeloVeiculo * milhasPorKm;

Console.WriteLine($"Seu veículo percorreu um total de {conversao} milhas.");




