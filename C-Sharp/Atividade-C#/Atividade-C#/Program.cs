
using Atividade_C_;


// Exercício 2
Console.WriteLine("*************** SISTEMA DO CINECIDADE***************");
Console.WriteLine();

// Instanciando objeto da classe Bike

CineCidade cineCidade = new CineCidade();

Console.Write("Nome Cliente: ");
cineCidade.Nome = Console.ReadLine();

Console.Write("Quantidade de Ingressos: ");
//Precisamos converter pra Int
cineCidade.QuantidadeIngressos = int.Parse(Console.ReadLine());

Console.Write("Cupom de Desconto: ");
cineCidade.Cupom = Console.ReadLine();

Console.Write("Idade do Cliente: ");
cineCidade.IdadeCliente = int.Parse(Console.ReadLine());


//Exibir na tela o resultado
Console.WriteLine("\n------ RESUMO DA COMPRA ------");

Console.WriteLine($"Cliente: {cineCidade.Nome.ToUpper()}");
Console.WriteLine($"Valor bruto: R${cineCidade.CalcularCustoBruto():F2}");
Console.WriteLine($"Valor final: R${cineCidade.CalcularDesconto():F2}");
Console.WriteLine($"Liberação para sessão noturna: {cineCidade.SessaoNoturna()}");





// EXERCÍCIO 2
Console.WriteLine("*************** SISTEMA DO FESTIVALCIDADE***************");
Console.WriteLine();

// Instanciando objeto da classe Bike

FestivalCidade festivalCidade= new FestivalCidade();

Console.Write("Nome fã: ");
festivalCidade.NomeFa = Console.ReadLine();

Console.Write("Quantidade de dias do show: ");
//Precisamos converter pra Int
festivalCidade.QuantidadeDiasShow = int.Parse(Console.ReadLine());

Console.Write("Cupom de Desconto: ");
festivalCidade.CupomShow = Console.ReadLine();

Console.Write("Pontuação Clube Fidelidade: ");
festivalCidade.PontuacaoFidelidade = int.Parse(Console.ReadLine());

//Exibir na tela o resultado
Console.WriteLine("\n------ RESUMO DA COMPRA ------");

Console.WriteLine($"Nome fã: {festivalCidade.NomeFa.ToUpper()}");
Console.WriteLine($"Valor bruto: R${festivalCidade.CalcularCustoBrutoShow():F2}");
Console.WriteLine($"Valor final: R${festivalCidade.CalcularDescontoShow():F2}");
Console.WriteLine($"Liberação para área VIP: {festivalCidade.AreaVip()}");