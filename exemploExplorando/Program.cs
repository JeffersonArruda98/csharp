using exemploExplorando.models;
using System.Globalization;
using models;
using Newtonsoft.Json;


Venda v1 = new Venda(1, "Material de escritório", 25.00M);

string serializado = JsonConvert.SerializeObject(v1);

Console.WriteLine(serializado);






























// int numero = 25;
// bool ehPar = false;

// //IF Ternário

// ehPar = numero % 2 == 0;
// Console.WriteLine($"O número {numero} é " + (ehPar ? "Par" : "Ímpar"));




// if (numero % 2 == 0)
// {
//     Console.WriteLine($"O número {numero} é Par.");
// }
// else
// {
//     Console.WriteLine($"O número {numero} é Ímpar");
// }





















// Pessoa p1 = new Pessoa("Jefferson", "Arruda");

// (string nome, string sobrenome) = p1;

// Console.WriteLine($"{nome} {sobrenome}");




















// LeituraArquivo arquivo = new LeituraArquivo();

// var (sucesso, linhasArquivo, _) = arquivo.LerArquivo("Arquivo/arquivoLeitura.txt");

// if (sucesso)
// {
//     // Console.WriteLine("Quantidade de linhas do arquivo: " + quantidadeLinhas);
//     foreach (String linha in linhasArquivo)
//     {
//         Console.WriteLine(linha);
//     }
// }
// else
// {
//     Console.WriteLine("Não foi possivel ler o arquivo");
// }















// (int Idade, string Nome, string Sobrenome, decimal Altura) tupla = (25, "Jefferson", "Arruda", 1.80M);

// ValueTuple<int, string, string, decimal> outroExemploTupla = (25, "Jefferson", "Arruda", 1.80M);

// var outroExemploTuplaCreate = Tuple.Create(25, "Jefferson", "Arruda", 1.80M);

// Console.WriteLine($"Idade: {tupla.Item1}");
// Console.WriteLine($"Nome: {tupla.Item2}");
// Console.WriteLine($"Sobrenome: {tupla.Item3}");
// Console.WriteLine($"Altura: {tupla.Item4}M");



























// Dictionary<string, string> estados = new Dictionary<string, string>();

// estados.Add("PE", "Pernambuco");
// estados.Add("BA", "Bahia");
// estados.Add("MG", "Minas Gerais");

// Console.WriteLine(estados["MG"]);


// foreach (var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// Console.WriteLine("--------------------------------------------------");

// estados.Remove("BA");
// estados["PE"] = "Pernambuco - Valor alterado";

// foreach(var item in estados)
// {
//     Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
// }

// string chave = "BA";
// Console.WriteLine($"Verificando o elemento: {chave}");

// if (estados.ContainsKey(chave))
// {
//     Console.WriteLine($"Valor existente: {chave}");
// }

// else
// {
//     Console.WriteLine($"Valor não existe. É seguro adicionar a chave: {chave}");
// }



















// Stack<int> pilha = new Stack<int>();

// pilha.Push(4);
// pilha.Push(6);
// pilha.Push(8);
// pilha.Push(10);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento do topo: {pilha.Pop()}");

// pilha.Push(20);

// foreach (int item in pilha)
// {
//     Console.WriteLine(item);
// }



















// Queue<int> fila = new Queue<int>();

// fila.Enqueue(2);
// fila.Enqueue(4);
// fila.Enqueue(6);
// fila.Enqueue(8);

// foreach (int item in fila) 
// {
//     Console.WriteLine(item);
// }

// Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}"); 
// fila.Enqueue(10);

// foreach (int item in fila)
// {
//     Console.WriteLine(item);
// }

















// new ExemploExcecao().Metodo1();
































// try
// {

//     string[] linhas = File.ReadAllLines("Arquivo/arquivoLeitura.txt");

//     foreach (string linha in linhas)
//     {
//         Console.WriteLine(linha);
//     }
// }
// catch (FileNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu umerro na leitura do arquivo. Arquivo não encontrado. {ex.Message}");
// }

// catch (DirectoryNotFoundException ex)
// {
//     Console.WriteLine($"Ocorreu um erro na leitura do arquivo. Caminho na pasta não encontrado. {ex.Message}");
// }

// catch (Exception ex)
// {
//     Console.WriteLine($"Ocorreu uma Excessão genérica. {ex.Message}");
// }

// finally
// {
//     Console.WriteLine("Chegou até aqui.");
// }



















// string dataString = "2024-05-20 22:12";

// bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);

// Console.WriteLine(data);

// if (sucesso)
// {
//     Console.WriteLine($"Conversão com sucesso! \nData: {data}");
// }

// else
// {
//     Console.WriteLine($"{dataString} não é uma data válida.");
// }















// CultureInfo.DefaultThreadCurrentCulture = new CultureInfo("pt-BR");

// decimal valorMonetario = 82.4M;

// Console.WriteLine(valorMonetario.ToString("C", CultureInfo.CreateSpecificCulture("en-US")));

// double porcentagem = .3421;

// Console.WriteLine(porcentagem.ToString("P"));

// int numero = 123456;

// Console.WriteLine(numero.ToString("##-##-##"));










// string numero1 = "10";
// string numero2 = "20";

// string resultado = numero1 + numero2;

// Console.WriteLine(resultado);


















// Pessoa p1 = new Pessoa(nome: "Jefferson", sobrenome: "Arruda");

// Pessoa p2 = new Pessoa(nome: "Maiara", sobrenome: "Raquel");

// Curso cursoDeIngles = new Curso();
// cursoDeIngles.Nome = "Ingles";
// cursoDeIngles.Alunos = new List<Pessoa>();

// cursoDeIngles.AdicionarAluno(p1);
// cursoDeIngles.AdicionarAluno(p2);
// cursoDeIngles.ListarAlunos();

