Album album1 = new Album();
album1.Nome = "Nirvana";

Musica musica1 = new Musica();
musica1.Nome = "Come as you are";
musica1.Duracao = 458;

album1.AdicionarMusica(musica1);
album1.ExibirMusicasDoAlbum();