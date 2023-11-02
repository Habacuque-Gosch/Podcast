Episodio ep1 = new(1, "Haba tech", 45);
ep1.AdicionarConvidados("Haba");
ep1.AdicionarConvidados("João");

Episodio ep2 = new(2, "HB Software", 75);
ep2.AdicionarConvidados("Haba");
ep2.AdicionarConvidados("Dud");
ep2.AdicionarConvidados("Kauan");

Podcast pod = new("Podcast Soft", "Habacuque");

pod.AdicionarEpisodio(ep1);
pod.AdicionarEpisodio(ep2);

pod.ExibirDetalhes();