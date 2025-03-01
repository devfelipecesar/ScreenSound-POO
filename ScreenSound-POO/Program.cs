Music musica1 = new Music(); //Criação de um objeto

musica1.Nome = "Roxane";
musica1.Artista = "The Police";
musica1.Duracao = 273;
musica1.Disponivel = true;

Console.WriteLine(musica1.DescricaoResumida);

Music musica2 = new Music();

musica2.Nome = "Vertigo";
musica2.Artista = "U2";
musica2.Duracao = 367;
musica2.Disponivel = false;


musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();

//musica1.ExibirMusicaArtista();
//musica2.ExibirMusicaArtista();
