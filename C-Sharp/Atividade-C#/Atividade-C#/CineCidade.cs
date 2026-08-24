using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_C_
{
    internal class CineCidade
    {
        //Declarações
        public string Nome { get; set; }

        public int QuantidadeIngressos { get; set; }

        public string Cupom { get; set; }

        public int IdadeCliente { get; set; }



        //Métodos
        //O programa deve calcular: O Custo Bruto: R$ 5,00 de taxa de conveniência/reserva + R$ 25,00 por ingresso comprado.
        public double CalcularCustoBruto()
        {
            double custoBruto = 5 + (25 * QuantidadeIngressos);
            return custoBruto;
        }

      
        // O Desconto: Se o cupom digitado for igual a "CINEMA10" (independente de maiúsculas/minúsculas), conceder 10% de desconto sobre o custo bruto; caso contrário, o desconto é R$ 0,00.
        public double CalcularDesconto()
        {
            Cupom = Cupom.ToUpper();
            double valorFinal= 0;

            if (Cupom == "CINEMA10")
            {
                valorFinal = CalcularCustoBruto() * 0.9;
            }
            else {
                valorFinal = CalcularCustoBruto();
            }    
            return valorFinal;
                               
        }
        
        public bool SessaoNoturna()
        {
            return (QuantidadeIngressos > 1 && (IdadeCliente >= 18));
        }

    }
}
