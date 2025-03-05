class Album
{
    private List<Music> musicas = new List<Music>();
    public string Nome { get; set; }
    public int DuracaoTotal => musicas.Sum(m => m.Duracao);

    public void AdicionarMusica(Music musica)
    {
        musicas.Add(musica);
    }

    public void ExibirMusicasDoAlbum()
    {
        Console.WriteLine($"Lista de músicas do album {Nome}\n");
        foreach (var musica in musicas)
        {
            Console.WriteLine($"Música: {musica.Nome}");
        }
        Console.WriteLine($"Para ouvir este álbum você precisa de {DuracaoTotal}");
    }
}