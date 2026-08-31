using Aula04_EscolaTecnica;

class Program
{
    static void Main(string[] args)
    {
        try
        {
            List<Pessoa> listaPessoas = new List<Pessoa>();
            int opcao = 0;
            do
            {
                Console.Clear();
                Console.WriteLine("=========== SISTEMA DE CADASTRO ===========");
                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("1 - Cadastrar Aluno");
                Console.WriteLine("2 - Cadastrar Professor");
                Console.WriteLine("3 - Listar todos os cadastros");
                Console.WriteLine("0 - Sair");

                string entrada = Console.ReadLine();

                if (int.TryParse(entrada, out opcao))
                {
                    switch (opcao)
                    {
                        case 1:
                            Console.Clear();
                            Console.WriteLine("===========Cadastro de Aluno===========");
                            Console.Write("Digite o nome do aluno: ");
                            string nomeAluno = Console.ReadLine();
                            Console.Write("Digite o curso técnico do aluno: ");
                            string curso = Console.ReadLine();
                            listaPessoas.Add(new Aluno(nomeAluno, curso));
                            break;
                        case 2:
                            Console.Clear();
                            Console.WriteLine("===========Cadastro de Professor===========");
                            Console.Write("Digite o nome do professor: ");
                            string nomeProfessor = Console.ReadLine();
                            Console.Write("Digite a disciplina do professor: ");
                            string disciplina = Console.ReadLine();
                            listaPessoas.Add(new Professor(nomeProfessor, disciplina));
                            break;

                        case 3:
                            Console.Clear();
                            Console.WriteLine("===========Lista de Cadastros===========");
                            if (listaPessoas.Count == 0)
                            {
                                Console.WriteLine("Nenhum cadastro encontrado.");

                            }
                            else
                            {
                                foreach (var pessoa in listaPessoas)
                                {
                                    pessoa.ExibirInformacoes();
                                    Console.WriteLine("-----------------------------------");
                                }
                            }
                            Console.WriteLine("Pressione qualquer tecla para voltar ao menu...");
                            Console.ReadKey();
                            break;


                        case 0:
                            Console.Clear();
                            Console.WriteLine("Saindo do sistema...");
                            break;
                        default:
                            Console.WriteLine("Opção inválida. Tente novamente.");
                            break;
                    }
                }


            } while (opcao != 0);
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ocorreu um erro: {ex.Message}");
        }
    }
}