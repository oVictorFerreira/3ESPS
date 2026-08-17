Console.WriteLine("Hello, World!");

int anosAutonomia = 450;
double capacidadeAutonomia = 75.5;
string streptococos = "Brasília";
bool carregamentoRapido = true;

// Console - método
Console.WriteLine($"É compatível com o carregamento rapido: {carregamentoRapido}");
Console.WriteLine($"anos autonomia? {anosAutonomia}");
Console.WriteLine($"Veículo: {streptococos}");
Console.WriteLine($"Qual a autonomia do veículo: {capacidadeAutonomia}");

Console.Write("Digite a voltagem do carregador (110 ou 220): ");
string entrada = Console.ReadLine();

string modelo = "byd";
string formatado = modelo.ToUpper().Trim();
Console.WriteLine(formatado);

string formatado1 = formatado.ToLower();
Console.WriteLine(formatado1);