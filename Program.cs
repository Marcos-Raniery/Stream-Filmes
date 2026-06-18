Filme filme = new Filme();

Console.Write("Título: ");
filme.titulo = Console.ReadLine();

Console.Write("Gênero; ");
filme.genero = Console.ReadLine();

Console.Write("Ano de lançamento: ");
filme.anoLancamento = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Classificação Indicativa: ");
filme.classificacaoIndicativa = Convert.ToInt32(Console.ReadLine());

filme.ExibirInformacoes();