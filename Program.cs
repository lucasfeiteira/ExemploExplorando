using ExemploExplorando.Models;
using System.Globalization;

string dataString = "2025-04-03 18:00";

bool sucesso = DateTime.TryParseExact(dataString,
                        "yyyy-MM-dd HH:mm",
                        CultureInfo.InvariantCulture,
                        DateTimeStyles.None, out DateTime data);

if (sucesso)
{
    System.Console.WriteLine($"Conversao com sucesso! data {data}");
}
else
{
    System.Console.WriteLine($"{dataString} nao é data válida");
}


















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 1582.40M;

// Console.WriteLine(valorMonetario.ToString("N2"));

// double porcentagem = .3421;

// System.Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;
// System.Console.WriteLine(numero.ToString("##-##-##"));









// int numero1 = 10;
// int numero2 = 20;

// int resultado = numero1 + numero2;

// System.Console.WriteLine(resultado);



























// Pessoa p1 = new Pessoa("Lucas", "Henrique");
// Pessoa p2 = new Pessoa("Eduardo", "Neves Queiroz");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();



















//---------------------------------------------
// Pessoa p1 = new Pessoa();
// p1.Nome = "Lucas";
// p1.Sobrenome = "Henrique"; 
// p1.Idade = 25;
// p1.Apresentar();

