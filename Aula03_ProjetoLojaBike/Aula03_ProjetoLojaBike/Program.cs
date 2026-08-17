
using Aula03_LojaBike;


Console.WriteLine("*************** SISTEMA DA LOJA BIKE CITY ***************");
Console.WriteLine();

// Instanciando objeto da classe Bike

Bike bike = new Bike();

Console.Write("Modelo Bike: ");
bike.Modelo = Console.ReadLine();

Console.Write("Capacidade da Bateria: ");
//Precisamos converter pra double
bike.Bateria = double.Parse(Console.ReadLine());

Console.Write("Peso do Ciclista: ");
bike.PesoCiclista = Convert.ToDouble(Console.ReadLine());

Console.Write("Quantidade Estimada de recargas por mês: ");
bike.RecargaMes = int.Parse(Console.ReadLine());


//Exibit na tela o resultado
Console.WriteLine("\n------ RELATÓRIO DE DESEMPENHO DA BIKE ------");
Console.WriteLine($"Bicicleta: {bike.Modelo.ToUpper()}");
Console.WriteLine($"Autonomia Estimada: {bike.CalcularAutonomia():F1}KM por carga");
Console.WriteLine($"Consumo mensal: {bike.CalcularConsumoMensal()}KWh");
Console.WriteLine($"Custo Mensal: {bike.CalcularCustoMensal():N2}");
Console.WriteLine($"A Bike é econômica {bike.ModeloEconomico()}");

