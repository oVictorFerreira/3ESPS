using Aula02_GitIgnore;

Console.WriteLine("Sistema de Vendas de Carros Elétricos");
Console.WriteLine();

// Polimorfismo - Ao invés de chamar CarroEletrico eu chamo só de carro
// Instância 
CarroEletrico carro = new CarroEletrico();
Console.WriteLine("Digite o modelo do carro: ");
carro.Modelo = Console.ReadLine();
Console.WriteLine($"Modelo: {carro.Modelo.Trim().ToUpper()}");
