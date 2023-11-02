class Podcast
{
    private List<Episodio> episodios = new();
    public string nome;
    public Podcast( string nome, string host)
    {
        Nome = nome;
        Host = host;
    }
    public string Nome {  get; }
    public string Host { get; }
    public int TotalDeEpisodios => episodios.Count;

    public void AdicionarEpisodio(Episodio episodio)
    {
        episodios.Add(episodio);
    }

    public void ExibirDetalhes()
    {
        Console.WriteLine($"Podcast: {Nome} apresentado por {Host}");
        foreach (Episodio episodio in episodios.OrderBy(e => e.Ordem))
        {
            Console.WriteLine(episodio.Resumo);
        }

        Console.WriteLine($"\nEste podcast possui {TotalDeEpisodios}");
    }
}