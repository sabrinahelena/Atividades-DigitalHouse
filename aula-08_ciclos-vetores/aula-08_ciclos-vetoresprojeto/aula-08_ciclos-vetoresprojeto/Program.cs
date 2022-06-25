// Essa é a lista de filmes disponibilizada pelo professor inicialmente.

String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };

// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
string apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    string filmes = "";
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        filmes = filmes + $"{listaDeFilmes[i]}; ";
    }
    return filmes;
}

// 1.2. Apresentar quantidade de filmes da lista.
int quantidadeTotalDeFilmes()
{
    return listaDeFilmes.Length;
}

//1.3  Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{
    string filme = listaDeFilmes[indiceDoFilme];
    return filme;
}

// 1.4. Adiciona um novo filme a lista pelo seu nome.
String[] adicionaUmNovoFilmePeloSeuNome(string nomeDoFilme)
{
    int novoTamanho = listaDeFilmes.Length + 1;

    string[] novaLista = new string[novoTamanho];

    for (int i = 0; i < listaDeFilmes.Length; i++)
        novaLista[i] = listaDeFilmes[i];

    novaLista[novoTamanho - 1] = nomeDoFilme;

    return novaLista;
}

// 1.5. Atualiza um filme a partir do seu índice na lista.

String[] atualizarUmFilmePeloSeuIndice(int indiceDoFilme)
{
    Console.WriteLine("Qual filme você deseja colocar nesse índice?");
    string filme = Console.ReadLine();
    listaDeFilmes[indiceDoFilme] = filme;
    Console.WriteLine($"O filme inserido no índice escolhido {indiceDoFilme} é: {filme}, e foi atualizado com sucesso!");
    return listaDeFilmes;

}

// 1.6. Listar todos os filmes com seu índice/posição na lista.
String[] listarTodosOsFilmesComSeuIndiceNaLista()
{
    for (int i = 0; i < listaDeFilmes.Length; i++)
    {
        Console.WriteLine($"{i} - {listaDeFilmes[i]}");

    }
    return listaDeFilmes;
}




