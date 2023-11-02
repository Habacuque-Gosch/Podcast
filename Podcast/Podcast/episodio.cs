class Episodio
{
    private List<string> convidados = new();
    public Episodio(int ordem, string titulo, int duracao )
    {
        Duracao = duracao;
        Titulo = titulo;
        Ordem = ordem;
    }

    public int Ordem { get; }
    public string Titulo { get; }
    public int Duracao { get; }
    
    public string Resumo => $"{Ordem}.{Titulo}({Duracao} min) - Covidados: {string.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }

}