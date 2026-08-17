using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula03_LojaBike
{
    internal class Bike
    {

        //Declarações
        public string Modelo { get; set; }

        public double Bateria {  get; set; }

        public double PesoCiclista {  get; set; }

        public int RecargaMes {  get; set; }

        //Métodos
        public double CalcularAutonomia()
        {
            double autonomiaBase = Bateria / 15;
            Boolean pesoElevado = PesoCiclista > 90.0;

            //Operador ternário
            return pesoElevado ? (autonomiaBase * 0.05) : (autonomiaBase);

        }

        public double CalcularConsumoMensal()
        {
            double kmPorCarga = Bateria / 1000.0;
            return kmPorCarga * RecargaMes;
        }

        public double CalcularCustoMensal()
        {
            const double PRECO_KWH = 0.80;
            return CalcularConsumoMensal() * PRECO_KWH;
        }

        public bool ModeloEconomico()
        {
            return (CalcularCustoMensal() < 15.00 || (CalcularAutonomia() > 40.0));
        }
    }
}
