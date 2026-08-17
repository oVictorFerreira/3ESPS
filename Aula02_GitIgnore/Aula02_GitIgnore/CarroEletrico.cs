using System;
using System.Collections.Generic;
using System.Text;

namespace Aula02_GitIgnore
{
    internal class CarroEletrico
    {
        // pega e modifica a informação - encapsulamento
        // Declarações

        public string Modelo { get; set; } = string.Empty;

        public double ValorBase {  get; set;} 

        public int Autonomia { get; set;} 

        public int Idade { get; set; }


        // Função 
        public double CalcularDesconto()
        {
            const double Desconto = 0.10;
            return ValorBase * Desconto;
        }
        public double CalcularValorDesconto()
        {
            return ValorBase - CalcularDesconto();
        }

        public double CalcularParcela() 
        {
            const double Juros_Financiamento = 5000.00;
            double valorTotalFinanciamento = CalcularValorDesconto() + Juros_Financiamento;
            return valorTotalFinanciamento/36;
        }
    }
}
