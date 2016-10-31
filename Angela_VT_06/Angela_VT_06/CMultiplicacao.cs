using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angela_VT_06
{
    class CMultiplicacao : COperacaoMatematica
    {
        double multi;

        public CMultiplicacao(double v1, double v2)
            : base(v1, v2)
        {
            multi = 0;
        }

        public double calculamulti()
        {
            multi = v1 * v2;
            return multi;
        }
    }
}
