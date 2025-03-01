class Music // Classe [usado o pascal case]
{
    public string Nome { get; set; } //Atributo / nome de variavel é usado o camel case
    public string Artista { get; set; }// Atributo
    public int Duracao { get; set; } // Atributo
    public bool Disponivel { get; set; } //propriedade [ usado pascal case]
    public string DescricaoResumida //criar propriedade [Atalho = prop+tab]
    {
        get
        {
            return $"A música {Nome} pertence à banda {Artista}";
        }
    } 


    public void ExibirFichaTecnica() // Método
    {
        Console.WriteLine($"Nome: {Nome}"); //Mostrar na tela [Atalho = CW+tab)
        Console.WriteLine($"Artista: {Artista}");
        Console.WriteLine($"Duração: {Duracao}");
        if (Disponivel)
        {
            Console.WriteLine("Disponível no plano");
        }
        else
        {
            Console.WriteLine("Adquira o plano Plus!");
        }
    }

    public void ExibirMusicaArtista()
    {
        Console.WriteLine($"Nome da música / artista: {Nome}/{Artista}");
    }
}
