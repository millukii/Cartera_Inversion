using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Acciones
    {
        public string fecha;
        public double precio;
        public Dictionary<string, double> lista_acciones;
        public Acciones()
        {
          this.lista_acciones = new Dictionary<string, double>();
        }

        public double get_precio(string fecha)
        {
            if (this.lista_acciones.ContainsKey(fecha))
                return this.lista_acciones[fecha];
            else
                return 0;
        }

        public void add_accion()
        {
            this.lista_acciones.Add(this.fecha, this.precio);
        }

        public Dictionary<string, double> getAcciones()
        {
            return this.lista_acciones;
        }

    }
}
