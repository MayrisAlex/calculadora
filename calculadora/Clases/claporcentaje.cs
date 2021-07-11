using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculadora.Clases
{
    class claporcentaje
    {
        public double porcentar(double N1, double N2)
        {
            double po, po_;
            po = (N1 * (N2 / 100));
            po_ = (N1-po);
            return po_;

        }
    }
}
