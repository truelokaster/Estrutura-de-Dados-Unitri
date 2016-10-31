using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angela_VT_06
{
    class CSubtracao : COperacaoMatematica
    {
        double subtracao;

        public CSubtracao(double v1, double v2)
            : base(v1, v2)
        {
            subtracao = 0;
        }

        public double calculasub()
        {
            subtracao = v1 - v2;
            return subtracao;
        }
    }
}
