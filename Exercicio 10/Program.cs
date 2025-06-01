class Program
{
    static List<Midia> catalogo = new List<Midia>();

    static void Main()
    {
        bool executando = true;
        while (executando)
        {
            Console.Clear();
            Console.WriteLine("=== PLATAFORMA DE STREAMING ===");
            Console.WriteLine("1. Adicionar Mídia ao Catálogo");
            Console.WriteLine("2. Listar Todo o Catálogo");
            Console.WriteLine("3. Pesquisar Mídia");
            Console.WriteLine("4. Adicionar Episódio a Série");
            Console.WriteLine("5. Alterar Disponibilidade");
            Console.WriteLine("6. Sair");
            Console.Write("Escolha uma opção: ");

            switch (Console.ReadLine())
            {
                case "1":
                    AdicionarMidia();
                    break;
                case "2":
                    ListarCatalogo();
                    break;
                case "3":
                    PesquisarMidia();
                    break;
                case "4":
                    AdicionarEpisodio();
                    break;
                case "5":
                    AlterarDisponibilidade();
                    break;
                case "6":
                    executando = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            if (executando)
            {
                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
            }
        }
    }

    static void AdicionarMidia()
    {
        Console.WriteLine("\n=== ADICIONAR MÍDIA ===");
        Console.WriteLine("1. Filme");
        Console.WriteLine("2. Série");
        Console.WriteLine("3. Documentário");
        Console.Write("Tipo de mídia: ");
        
        string tipo = Console.ReadLine();
        
        Console.Write("Título: ");
        string titulo = Console.ReadLine();
        
        Console.Write("Duração (hh:mm): ");
        TimeSpan duracao = TimeSpan.Parse(Console.ReadLine());
        
        Console.Write("Gênero: ");
        string genero = Console.ReadLine();

        switch (tipo)
        {
            case "1":
                Console.Write("Diretor: ");
                string diretor = Console.ReadLine();
                
                Console.Write("Ano: ");
                int ano = int.Parse(Console.ReadLine());
                
                Console.WriteLine("Elenco (digite os nomes separados por vírgula):");
                var elenco = Console.ReadLine().Split(',').Select(e => e.Trim()).ToList();
                
                catalogo.Add(new Filme(titulo, duracao, genero, diretor, ano, elenco));
                break;
                
            case "2":
                Console.Write("Número de temporadas: ");
                int temporadas = int.Parse(Console.ReadLine());
                
                Console.Write("Número total de episódios: ");
                int episodios = int.Parse(Console.ReadLine());
                
                catalogo.Add(new Serie(titulo, duracao, genero, temporadas, episodios));
                break;
                
            case "3":
                Console.Write("Tema: ");
                string tema = Console.ReadLine();
                
                Console.Write("Narrador: ");
                string narrador = Console.ReadLine();
                
                Console.Write("Baseado em fatos? (S/N): ");
                bool baseadoEmFatocos = Console.ReadLine().ToUpper() == "S";
                
                catalogo.Add(new Documentario(titulo, duracao, genero, tema, narrador, baseadoEmFatocos));
                break;
                
            default:
                Console.WriteLine("Tipo de mídia inválido!");
                return;
        }

        Console.WriteLine("\nMídia adicionada com sucesso ao catálogo!");
    }

    static void ListarCatalogo()
    {
        Console.WriteLine("\n=== CATÁLOGO COMPLETO ===");
        foreach (var midia in catalogo)
        {
            midia.ExibirResumo();
            Console.WriteLine();
        }
    }

    static void PesquisarMidia()
    {
        Console.Write("\nDigite o título ou parte dele: ");
        string termo = Console.ReadLine().ToLower();
        
        var resultados = catalogo.Where(m => m.Titulo.ToLower().Contains(termo)).ToList();
        
        if (resultados.Any())
        {
            Console.WriteLine("\nResultados da pesquisa:");
            foreach (var midia in resultados)
            {
                midia.ExibirResumo();
                Console.WriteLine();
            }
        }
        else
        {
            Console.WriteLine("\nNenhuma mídia encontrada com esse termo.");
        }
    }

    static void AdicionarEpisodio()
    {
        var series = catalogo.OfType<Serie>().ToList();
        
        if (!series.Any())
        {
            Console.WriteLine("\nNão há séries cadastradas!");
            return;
        }

        Console.WriteLine("\n=== ADICIONAR EPISÓDIO ===");
        Console.WriteLine("Séries disponíveis:");
        for (int i = 0; i < series.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {series[i].Titulo}");
        }
        Console.Write("Selecione a série: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        
        Console.Write("Número da temporada: ");
        int temporada = int.Parse(Console.ReadLine());
        
        Console.Write("Número do episódio: ");
        int numero = int.Parse(Console.ReadLine());
        
        Console.Write("Título do episódio: ");
        string titulo = Console.ReadLine();
        
        Console.Write("Duração (hh:mm): ");
        TimeSpan duracao = TimeSpan.Parse(Console.ReadLine());
        
        Console.Write("Sinopse: ");
        string sinopse = Console.ReadLine();
        
        series[index].AdicionarEpisodio(new Episodio(temporada, numero, titulo, duracao, sinopse));
        Console.WriteLine("\nEpisódio adicionado com sucesso!");
    }

    static void AlterarDisponibilidade()
    {
        if (!catalogo.Any())
        {
            Console.WriteLine("\nO catálogo está vazio!");
            return;
        }

        Console.WriteLine("\n=== ALTERAR DISPONIBILIDADE ===");
        Console.WriteLine("Mídias disponíveis:");
        for (int i = 0; i < catalogo.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {catalogo[i].Titulo} ({(catalogo[i].Disponivel ? "Disponível" : "Indisponível")})");
        }
        Console.Write("Selecione a mídia: ");
        int index = int.Parse(Console.ReadLine()) - 1;
        
        Console.Write("Disponível? (S/N): ");
        bool disponivel = Console.ReadLine().ToUpper() == "S";
        
        catalogo[index].AlterarDisponibilidade(disponivel);
        Console.WriteLine("\nDisponibilidade atualizada com sucesso!");
    }
}