using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Cartera_Simple
    {
        public Acciones acc;
        public Cartera_Simple(Acciones acc)
        {
            this.acc = acc;
        }

        public double Beneficio(string fecha_ini, string fecha_fin)
        {
            double valor_ini = this.acc.get_precio(fecha_ini);
            double valor_fin = this.acc.get_precio(fecha_fin);

            return ((valor_fin/valor_ini) - 1) * 100;

        }

        public double Profit(string fecha_ini, string fecha_fin, int years)
        {
            if (years == 0)
                years = 1;

            double valor_ini = this.acc.get_precio(fecha_ini);
            double valor_fin = this.acc.get_precio(fecha_fin);

            return ((Math.Pow((valor_fin / valor_ini), 1 / years) - 1) * 100);
        }
    }
}
