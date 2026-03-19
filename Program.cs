using ExercicioProjeto.Models;

Projeto proj = new Projeto();

bool menu = true;
// Loop para a exibição do menu
while (menu == true)
{
    Console.Clear();
    Console.WriteLine("---- Bem vindo ao Gerenciador de Projetos! ----");
    Console.WriteLine("O que você deseja?\n");
    Console.WriteLine("[1] - Cadastrar um projeto");
    Console.WriteLine("[2] - Alterar dados de um projeto");
    Console.WriteLine("[3] - Exibir todos os projetos cadastrados");
    Console.WriteLine("[4] - Excluir um projeto");
    Console.WriteLine("[0] - Encerrar o Programa");

    switch (Console.ReadLine())
    {
        case "1":
            proj.Cadastro();
            break;

        case "2":
            proj.Alterar();
            break;

        case "3":
            proj.Exibir();
            break;

        case "4":
            proj.Excluir();
            break;

        case "0":
            menu = false;
            break;

        default:
            Console.WriteLine("Opção inválida");
            break;        
    }

    Console.WriteLine("Pressione uma tecla para continuar");
    Console.ReadLine();
}
Console.WriteLine("Até a próxima");