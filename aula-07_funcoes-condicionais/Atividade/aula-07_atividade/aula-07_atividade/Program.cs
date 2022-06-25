// Cotação do dólar no dia 3 de maio de 2022.
double cotacaoDoDolarHoje = 4.97; //não está declarado como constante pois pode variar.
const double VALOR_MINIMO_DE_COMPRA_EM_DOLAR = 100;
const double VALOR_MAXIMO_DE_COMPRA_EM_DOLAR = 2500;
double valorUsuarioEmReais;
double valorConvertido;

double converterRealParaDolar(double valorDaCompraEmReais)
{
    valorConvertido = valorDaCompraEmReais / cotacaoDoDolarHoje;

    if(valorConvertido < VALOR_MINIMO_DE_COMPRA_EM_DOLAR)
    {
        Console.WriteLine($"A compra mínima permitida é de USD$ {VALOR_MINIMO_DE_COMPRA_EM_DOLAR} e você possui USD$ {Math.Round(valorConvertido)}");
    }
    else if(valorConvertido > VALOR_MAXIMO_DE_COMPRA_EM_DOLAR)
    {
        Console.WriteLine($"A compra máxima permitida é de USD$ {VALOR_MAXIMO_DE_COMPRA_EM_DOLAR} e você possui USD$ {Math.Round(valorConvertido)}");

    }
    else
    {
        Console.WriteLine($"Você pode comprar USD$ {Math.Round(valorConvertido)}");

    }
    return valorConvertido;
}

Console.WriteLine("Digite o seu nome: ");
string nomeUsuario = Console.ReadLine();
Console.WriteLine($"Olá {nomeUsuario}! Seja bem-vindo. Digite o valor que você possui em reais: ");
valorUsuarioEmReais = int.Parse(Console.ReadLine());
converterRealParaDolar(valorUsuarioEmReais); //joga o valor inserido pelo usuário como parâmetro na função



