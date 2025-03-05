Album albumDoQueen = new Album();
albumDoQueen.Nome = "A nigth at the opera";

Music musica1 = new Music();
musica1.Nome = "Love of my Life";
musica1.Duracao = 213;

Music musica2 = new Music();
musica2.Nome = "Bohemian Rhapsody";
musica2.Duracao = 354;

albumDoQueen.AdicionarMusica(musica1);
albumDoQueen.AdicionarMusica(musica2);

albumDoQueen.ExibirMusicasDoAlbum();