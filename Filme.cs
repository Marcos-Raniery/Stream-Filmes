public class Filme
{
    public string titulo;
    public string genero;
    public int anoLancamento;
    public int classificacaoIndicativa;

    public string ObterClassificacaoIndicativa()
    {
        if (classificacaoIndicativa <= 0)
        {
            return "Livre";
        }
        return classificacaoIndicativa.ToString() + " anos";
    }

    public void ExibirInformacoes()
    {
        Console.WriteLine("\n=== Filme Cadastrado ===");
        Console.WriteLine("Título: " + titulo);
        Console.WriteLine("Gênero: " + genero);
        Console.WriteLine("Ano de Lançamento: " + anoLancamento);
        Console.WriteLine("Classificação Indicativa: " + ObterClassificacaoIndicativa());
    }
}