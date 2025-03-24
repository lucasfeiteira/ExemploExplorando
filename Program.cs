using ExemploExplorando.Models;

Pessoa p1 = new Pessoa("Lucas", "Henrique");
Pessoa p2 = new Pessoa("Eduardo", "Neves Queiroz");

Curso cursoDeIngles = new Curso();
cursoDeIngles.Nome = "Ingles";
cursoDeIngles.Alunos = new List<Pessoa>();

cursoDeIngles.AdicionarAluno(p1);
cursoDeIngles.AdicionarAluno(p2);
cursoDeIngles.ListarAlunos();



















//---------------------------------------------
// Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas";
// p1.Sobrenome = "Henrique"; 
// p1.Idade = 25;
// p1.Apresentar();

