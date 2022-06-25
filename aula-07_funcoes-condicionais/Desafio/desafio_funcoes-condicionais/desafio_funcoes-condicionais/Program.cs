
string retornarDiagnosticoDoUsuario(double alturaDoUsuario, double pesoDoUsuario) //função que calcula IMC e retorna a situação do usuário
{
    double IMC = alturaDoUsuario / (Math.Pow(pesoDoUsuario, 2));
 

    if (IMC < 18.5)
    {
        return "abaixo do peso";
    }
    else if (IMC >= 18.5 && IMC <= 24.9)
    {
        return "normal";
    }
    else if (IMC >= 25 && IMC <= 29.9)
    {
        return "sobrepeso";
    }
    else if (IMC >= 30 && IMC <= 40)
    {
        return "obesidade";
    }
    else
    {
        return "obesidade grave";
    }
  
}

Console.WriteLine("Digite o seu peso: ");
var pesoUsuario = double.Parse(Console.ReadLine());
Console.WriteLine("Agora digite a sua altura: ");
var alturaUsuario = double.Parse(Console.ReadLine());

Console.WriteLine($"Seu diagnóstico é {retornarDiagnosticoDoUsuario(pesoUsuario, alturaUsuario)}");
