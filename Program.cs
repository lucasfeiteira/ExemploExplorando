using ExemploExplorando.Models;
using System.Globalization;
using Newtonsoft.Json;

int a = 10;

int b = a;
b = 60;

System.Console.WriteLine($"Valor de A: {a}");

System.Console.WriteLine($"Valor de B: {b}");

























// Pessoa p1 = new Pessoa(nome: "Leonardo", sobrenome: "Buta");

// Pessoa p2 = p1;
// p2.Nome = "Eduardo";

// System.Console.WriteLine(p1.NomeCompleto);
// System.Console.WriteLine(p2.NomeCompleto);
























//------------------------------------------------------------
//  int numero = 20;
//  bool par = false;

// // IF ternário
//  par = numero.Ehpar();

// string mensagem = "O número " + numero + "" + " é " + (par ? "par" : "impar");
// Console.WriteLine(mensagem);





















// MeuArray<int> arrayInteiro = new MeuArray<int>();

// arrayInteiro.AdicionarElementoArray(30);

// System.Console.WriteLine(arrayInteiro[0]);

// MeuArray<string> arrayString = new MeuArray<string>();

// arrayString.AdicionarElementoArray("tedste");

// System.Console.WriteLine(arrayString[0]);





















// dynamic variavelDinamica = 4; 

// System.Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");

// variavelDinamica = "texte";

// System.Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");


// variavelDinamica = true;

// System.Console.WriteLine($"Tipo da variavel: {variavelDinamica.GetType()}, Valor: {variavelDinamica}");














//  string conteudoArquivo = File.ReadAllText("Arquivos/venda.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// var listaAnonimo = listaVendas.Select(x => new { x.Produto, x.Preco });

// foreach (var venda in listaAnonimo)
// {
//     Console.WriteLine($"Produto: {venda.Produto}, Preço: {venda.Preco}");
// }











// var tipoAnonimo = new { Nome = "Lucas", Sobrenome = "Buta", Altura = 1.80 };

// Console.WriteLine("Nome: " + tipoAnonimo.Nome);
// Console.WriteLine("Sobrenome: " + tipoAnonimo.Sobrenome);
// Console.WriteLine("Altura: " + tipoAnonimo.Altura);


















// string conteudoArquivo = File.ReadAllText("Arquivos/venda.json");

// List<Venda> listaVendas = JsonConvert.DeserializeObject<List<Venda>>(conteudoArquivo);

// foreach (Venda venda in listaVendas)
// {
//     Console.WriteLine($"Id: {venda.Id}, Produto: {venda.Produto}, " +
//                       $"Preço: {venda.Preco}, Data: {venda.DataVenda.ToString("dd/MM/yyyy HH:mm")}, " +
//                       $" {(venda.Desconto.HasValue ? $"Desconto de: {venda.Desconto}" : "")} ");
// }






















// bool? desejaReceberEmail = true;

// if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
// {
//     Console.WriteLine("O usuario optou por receber e-mail.");
// }
// else
// {
//     Console.WriteLine("O usuario não respondeu ou optou por não receber e-mail.");
// }
















// DateTime dataAtual = DateTime.Now;
// List<Venda> listaVendas = new List<Venda>();

// Venda v1 = new Venda(1, "Material de escritório", 25.00M, dataAtual);

// Venda v2 = new Venda(2, "Licença de Software", 110.00M, dataAtual);

// listaVendas.Add(v1);
// listaVendas.Add(v2);    

// string serializado = JsonConvert.SerializeObject(listaVendas, Formatting.Indented);

// System.Console.WriteLine(serializado);

// File.WriteAllText("Arquivos/venda.json", serializado);












//------------------------------------------------------------------
// int numero = 15;
// bool ehpar = false;

// // IF ternário
// ehpar = numero % 2 == 0;

// System.Console.WriteLine($"O numero {numero} é " + (ehpar ? "par" : "impar"));

// if (numero % 2 == 0)
// {
//     System.Console.WriteLine($"O numero {numero} é par");
// }
// else
// {
//     System.Console.WriteLine($"O numero {numero} é impar");
// }












// Pessoa p1 = new Pessoa("Lucas", "Henrique");

// (string nome, string sobrenome) = p1;

// System.Console.WriteLine($"{nome}, {sobrenome}");


















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivos/arquivoLeitura.txt");

// if (sucesso)
// {
//     //System.Console.WriteLine($"Quantidade de linhas: {quantidadeLinhas}");
//     foreach (var item in linhasArquivo)
//     {
//         System.Console.WriteLine(item);
//     }
// }
// else
// {
//     System.Console.WriteLine($"Erro ao ler o arquivo.");
// }
 



















// (int Id, string Nome, string Sobrenome, decimal Altura) tupla = (1, "Lucas", "Henrique", 1.80M);

// // ValueTuple<int, string, string, decimal> outroExemploTupla = (1, "Lucas", "Henrique", 1.80M);
// // var outroExemploTuplaCreate = Tuple.Create(1, "Lucas", "Henrique", 1.80M);

// System.Console.WriteLine($"Id: {tupla.Id}");
// System.Console.WriteLine($"Nome: {tupla.Nome}");
// System.Console.WriteLine($"Sobrenome: {tupla.Sobrenome}");
// System.Console.WriteLine($"Altura: {tupla.Altura}");



















///------------------------------------------------------------------------
// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("SP", "São Paulo");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// System.Console.WriteLine(estados["MG"]);

// foreach (var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// System.Console.WriteLine("-----------------------");
// estados.Remove("BA");
// estados["SP"] = "São Paulo - valor alterado";

// foreach (var item in estados)
// {
//     System.Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA2";
// System.Console.WriteLine($"Verificando o elemento: {chave}");
// if (estados.ContainsKey(chave))
// {
//     System.Console.WriteLine($"Valor existente: {chave}");
// }
// else
// {
//     System.Console.WriteLine($"Valor não existe É seguro adicionar a chave: {chave}");
// }
















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4); 
// pilha.Push(6); 
// pilha.Push(8); 
// pilha.Push(10); 

// foreach (var item in pilha)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento: {pilha.Pop()}");
// pilha.Push(20);

// foreach (var item in pilha)
// {
//     System.Console.WriteLine(item);
// }
























// Queue<int> fila = new Queue<int>();
// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila)
// {
//     System.Console.WriteLine(item);
// }

// System.Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
// fila.Enqueue(10);


// foreach (int item in fila) 
// {
//     System.Console.WriteLine(item);
// }



















//new ExemploExcecao().Metodo1();






























// try
// {
//     string[] linhas = File.ReadAllLines("Arquivos/d/a_rquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         System.Console.WriteLine(linha);
//     }

// }
// catch (FileNotFoundException ex)
// {
//     System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }

// catch (DirectoryNotFoundException ex)
// {
//     System.Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho da pasta não encontrado. {ex.Message}");
// }

// catch (Exception ex)
// {
//     System.Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
// }
// finally
// {
//     System.Console.WriteLine($"Chegou até aqui!");   
// }




























// string dataString = "2025-04-03 18:00";

// bool sucesso = DateTime.TryParseExact(dataString,
//                         "yyyy-MM-dd HH:mm",
//                         CultureInfo.InvariantCulture,
//                         DateTimeStyles.None, out DateTime data);

// if (sucesso)
// {
//     System.Console.WriteLine($"Conversao com sucesso! data {data}");
// }
// else
// {
//     System.Console.WriteLine($"{dataString} nao é data válida");
// }


















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

