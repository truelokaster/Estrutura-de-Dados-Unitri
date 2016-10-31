using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angela_VT_06
{
    class CMedia : COperacaoMatematica
    {
        double media;

        public CMedia(double v1, double v2)
            : base(v1, v2)
        {
            media = 0;
        }

        public double calculamedia()
        {
            media = (v1 + v2)/2;
            return media;
        }
    }
}
