using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angela_VT_06
{
    class CDivisao : COperacaoMatematica
    {
        double divisao;

        public CDivisao(double v1, double v2)
            : base(v1, v2)
        {
            divisao = 0;
        }

        public double calculadiv()
        {

            if (v2 == 0)
                v2 = 0;
            else divisao = v1 / v2;
            return divisao;
        }
    }
}
