# Gerenciador de Projetos

Descrição
- Exercício de um professor meu que consiste numa aplicação console em C# para gerenciar projetos acadêmicos (cadastro, alteração, listagem e exclusão).

Funcionalidades
- Cadastrar um projeto (Nome, Aluno, Área, Semestre, Status).
- Alterar dados de um projeto existente.
- Exibir todos os projetos cadastrados.
- Excluir um projeto e reindexar os IDs.

Arquivos principais
- [Program.cs](Program.cs): ponto de entrada e menu interativo.
- [Models/Projeto.cs](Models/Projeto.cs): implementação da lógica.
- [ExercicioProjeto.csproj](ExercicioProjeto.csproj): arquivo de projeto (.NET).

Requisitos
- .NET 10 SDK (alvo: `net10.0`).

Como executar
```bash
dotnet build
dotnet run
```

Uso
- Ao executar, o programa mostra um menu com as opções:
  - `[1]` Cadastrar um projeto
  - `[2]` Alterar dados de um projeto
  - `[3]` Exibir todos os projetos cadastrados
  - `[4]` Excluir um projeto
  - `[0]` Encerrar o programa
- Siga as instruções no console para inserir ou atualizar campos.

Detalhes de implementação
- Os projetos são armazenados em um array estático `Projeto[] projetos` com capacidade fixa de 20 itens.
- Cada `Projeto` é um `struct` que contém campos: `Id`, `NomeProj`, `NomeAluno`, `Area`, `Semestre`, `Status`.
- O ID é atribuído sequencialmente no momento do cadastro e é reindexado quando um projeto é excluído.


Notas
- Para saber mais sobre os requisitos do exercício confira o [PDF](Exercício-Pratico-Struct.pdf)