using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula04_EscolaTecnica
{
    class Professor : Pessoa
    {
        public string Disciplina { get; set; }

        public Professor(string nome, string disciplina) : base(nome)
        {
            Disciplina = disciplina;
        }

        public override void ExibirInformacoes()
        {
            Console.WriteLine($"[PROFESSOR]: {Nome} \n [DISCIPLINA]: {Disciplina}");
        }

    }
}