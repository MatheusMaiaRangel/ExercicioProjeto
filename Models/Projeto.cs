namespace ExercicioProjeto.Models;

struct Projeto
{
    int Id;
    string NomeProj;
    string NomeAluno;
    string Area;
    int Semestre;
    string Status;

    static Projeto[] projetos = new Projeto[20];
    static int Quantidade { get; set; }


    // ---------- Métodos ---------------
    public void Cadastro()
    {
        Console.Clear();
        if (Quantidade >= projetos.Length)
        {
            Console.WriteLine("Não há espaço disponível para novos projetos.");
            return;
        }

        Projeto p = new Projeto();
        p.Id = Quantidade + 1;

        Console.Write("Nome do projeto: ");
        p.NomeProj = Console.ReadLine();

        Console.Write("Nome do aluno: ");
        p.NomeAluno = Console.ReadLine();

        Console.Write("Área: ");
        p.Area = Console.ReadLine();

        Console.Write("Semestre (número): ");
        p.Semestre = Convert.ToInt32(Console.ReadLine());

        Console.Write("Status: ");
        p.Status = Console.ReadLine();

        projetos[Quantidade] = p;
        Quantidade++;

        Console.WriteLine($"Projeto cadastrado com ID {p.Id}.");
    }

    public void Alterar()
    {
        Console.Clear();
        if (Quantidade == 0)
        {
            Console.WriteLine("Não há projetos cadastrados.");
            return;
        }

        Console.Write("Informe o ID do projeto a alterar: ");
        int LerId = Convert.ToInt32(Console.ReadLine());
        int id = LerId;

        if (id < 1 || id > Quantidade)
        {
            Console.WriteLine("Esse projeto não existe.");
            return;
        }

        int idA = id - 1; // Indicando a posição no array
        Projeto atual = projetos[idA];

        Console.Write($"Nome do projeto ({atual.NomeProj}): ");
        string entrada = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(entrada)) projetos[idA].NomeProj = entrada; // Altera se a entrada não for vazia

        Console.Write($"Nome do aluno ({atual.NomeAluno}): ");
        entrada = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(entrada)) projetos[idA].NomeAluno = entrada;

        Console.Write($"Área ({atual.Area}): ");
        entrada = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(entrada)) projetos[idA].Area = entrada;

        Console.Write($"Semestre ({atual.Semestre}): ");
        entrada = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(entrada) && int.TryParse(entrada, out int sem)) projetos[idA].Semestre = sem;

        Console.Write($"Status ({atual.Status}): ");
        entrada = Console.ReadLine();
        if (!string.IsNullOrWhiteSpace(entrada)) projetos[idA].Status = entrada;

        Console.WriteLine($"Projeto com ID {id} atualizado.");
    }

    public void Exibir()
    {
        Console.Clear();
        if (Quantidade == 0)
        {
            Console.WriteLine("Nenhum projeto por enquanto.");
            return;
        }

        Console.WriteLine("Projetos cadastrados:");
        for (int i = 0; i < Quantidade; i++)
        // foreach (var p in projetos)
        {
            var p = projetos[i];
            Console.WriteLine($"ID: {p.Id}\nNome do Projeto: {p.NomeProj}\nNome do Aluno: {p.NomeAluno}\nÁrea: {p.Area}\nSemestre: {p.Semestre}\nStatus: {p.Status}\n -----------------------------");
        }
    }

    public void Excluir()
    {
        Console.Clear();
        if (Quantidade == 0)
        {
            Console.WriteLine("Não há projetos cadastrados.");
            return;
        }

        Console.Write("Informe o ID do projeto a excluir: ");
        int LerId = Convert.ToInt32(Console.ReadLine());
        int id = LerId;

        if (id < 1 || id > Quantidade)
        {
            Console.WriteLine("Esse projeto não existe.");
            return;
        }

        int idE = id - 1; // Indicando a posição q vai ser excluida no array
        for (int i = idE; i < Quantidade - 1; i++)
        {
            projetos[i].Id = i + 1; 
        }
        projetos[Quantidade - 1] = new Projeto(); 
        Quantidade--;

        Console.WriteLine($"Projeto com ID {id} excluído.");
    }

}

