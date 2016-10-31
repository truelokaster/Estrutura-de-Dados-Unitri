using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angela_VT_06
{
    class CSoma:COperacaoMatematica
    {
        double somatorio;

        public CSoma(double v1, double v2)
            : base(v1, v2)
        {
            somatorio = 0;
        }

        public double calculasoma()
        {
            somatorio = v1 + v2;
            return somatorio;
        }
    }
}
