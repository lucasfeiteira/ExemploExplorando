﻿using ExemploExplorando.Models;
using System.Globalization;



Dictionary<string, string> estados = new Dictionary<string, string>();

estados.Add("SP", "São Paulo");
estados.Add("BA", "Bahia");
estados.Add("MG", "Minas Gerais");

System.Console.WriteLine(estados["MG"]);

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

