// Essa é a lista de filmes disponibilizada pelo professor inicialmente.
String[] listaDeFilmes = { "Clube dos Cinco", "A Hora do Pesadelo", "Karatê Kid", "Rocky IV", "Conan, o Bárbaro", "Highlander" };



// 1.1. Apresenta todos os filmes da lista separados por ponto e vírgula.
void apresentaTodosOsFilmesSeparadosPorPontoVirgula()
{
    for(int i = 0; i < listaDeFilmes.Length; i++)
    { 
        Console.WriteLine($"{listaDeFilmes[i]};");
    }

}

// 1.2. Apresentar quantidade de filmes da lista.
void quantidadeTotalDeFilmes()
{
    Console.WriteLine($"São: {listaDeFilmes.Length} filmes no total, de 0 a 5");
}



// 1.3. Buscar o nome do filme de acordo com seu índice.
string buscarNomeDoFilmePeloIndice(int indiceDoFilme)
{
    var nomePorIndice = listaDeFilmes[indiceDoFilme];
    Console.WriteLine($"O filme de índice {indiceDoFilme} é o filme {nomePorIndice}");

    return nomePorIndice;
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
    Console.WriteLine("Qual o nome do filme que deseja atualizar o índice?: ");
    string nomeFilme = Console.ReadLine();
    string listaAtualizada = listaDeFilmes[indiceDoFilme] = nomeFilme;
    return listarTodosOsFilmesComSeuIndiceNaLista();

}


// 1.6. Listar todos os filmes com seu índice/posição na lista.
String[] listarTodosOsFilmesComSeuIndiceNaLista()
{
    for(int i = 0; i<listaDeFilmes.Length; i++)
    {
        Console.WriteLine($"{i} - {listaDeFilmes[i]}");
    }
    return listaDeFilmes;
}

