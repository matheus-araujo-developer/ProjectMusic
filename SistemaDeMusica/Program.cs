Banda bandaNova = new Banda("Nirvana Full");

Album album1 = new Album("Nirvana");

Musica musica1 = new Musica(bandaNova, "Come as you are")
{
    Duracao = 458,
    Disponivel = true,
};

Musica musica2 = new Musica(bandaNova, "Your Sound")
{
    Duracao = 453,
    Disponivel = false,
};

album1.AdicionarMusica(musica1);
album1.AdicionarMusica(musica2);
bandaNova.AdionarAlbum(album1);

musica1.ExibirFichaTecnica();
musica2.ExibirFichaTecnica();
album1.ExibirMusicasDoAlbum();
bandaNova.ExibirDiscografia();