namespace ExercicioProjeto.Models;

struct Projeto
{
    public int Id;
    public string NomeProj;
    public string NomeAluno;
    public string Area;
    public int Semestre;
    public string Status;

    private static Projeto[] projetos = new Projeto[20];
    public static int Quantidade { get; private set; }


// ---------- Métodos ---------------
    public void Cadastro()
    {
        if (Quantidade >= projetos.Length)
        {
            Console.WriteLine("Não há espaço disponível para novos projetos.");
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

    public static Projeto[] Obterprojetos() => projetos;
}

