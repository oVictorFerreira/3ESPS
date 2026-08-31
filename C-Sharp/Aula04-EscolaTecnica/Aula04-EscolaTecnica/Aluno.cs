using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_EscolaTecnica
{
    // Herança: A classe Aluno herda da classe Pessoa, o que significa que ela possui todos os atributos e métodos da classe Pessoa, além de seus próprios atributos e métodos.
    class Aluno : Pessoa
    {

        // Propriedade oara armazenar o curso técnico do aluno
        public string CursoTecnico { get; set; }

        // Construtor da classe aluno que repassa o nome da pessoa para o construtor da classe base Pessoa
        public Aluno(string nome, string cursoTecnico) : base(nome)
        {
            CursoTecnico = cursoTecnico;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[ALUNO]: {Nome} \n [CURSO TÉCNICO]: {CursoTecnico}");
        }
    }
}
