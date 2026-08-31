using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_EscolaTecnica
{
    public class Pessoa
    {
        private string nome;

        public string Nome{
            // Retorna o valor do campo privado
            get { return nome; }
            //Define o novo valor para o campo privado
            set { nome = value; }
        }

        // Construtor da classe base pessoa para inicializar o atributo nome
        public Pessoa(string nome)
        {
            this.Nome = nome;
        }

        // Metodo virtual - Pode ser uma forma de polimorfismo (ação que faz duas coisas diferentes) Ex.: Pato e galinha (ambos sao aves, mas a galinha nao voa)
            
        public virtual void ExibirInformacoes()
        {
            Console.WriteLine($"Nome: {Nome}");
        }
    
    }
}
