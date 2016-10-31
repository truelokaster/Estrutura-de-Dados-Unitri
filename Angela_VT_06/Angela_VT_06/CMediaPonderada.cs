using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Angela_VT_06
{
    class CMediaPonderada:CMedia
    {

        protected double p1, p2;
        double mediapond;

        public CMediaPonderada(double v1, double v2, double pes1, double pes2)
            : base(v1, v2)
            
        {
            p1 = pes1;
            p2 = pes2;
            mediapond = 0;
        }

        public double calculamediapond()
        {
            mediapond = (v1 * p1 + v2 * p2);
            return mediapond;
        }
    }
}
