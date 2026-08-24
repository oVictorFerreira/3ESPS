using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_C_
{
    internal class FestivalCidade
    {
        //Declarações
        public string NomeFa { get; set; }

        public int QuantidadeDiasShow { get; set; }

        public string CupomShow { get; set; }

        public int PontuacaoFidelidade { get; set; }


        //Métodos
        public double CalcularCustoBrutoShow()
        {
            double custoBrutoShow = 15 + (120 * QuantidadeDiasShow);
            return custoBrutoShow;
        }

        public double CalcularDescontoShow()
        {
            CupomShow = CupomShow.ToUpper();
            double valorFinal = 0;

            if (CupomShow == "ROCK10S")
            {
                valorFinal = CalcularCustoBrutoShow() * 0.9;
            }
            else
            {
                valorFinal = CalcularCustoBrutoShow();
            }
            return valorFinal;

        }

        public bool AreaVip()
        {
            return (QuantidadeDiasShow > 2 && (PontuacaoFidelidade >= 500));
        }
    }
}
