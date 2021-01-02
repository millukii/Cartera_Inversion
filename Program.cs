using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("#INICIO#");
            Acciones acc = new Acciones();
            Cartera_Simple cs = new Cartera_Simple(acc);
            //agregar acciones
            acc.fecha = "2020-12-21";
            acc.precio = 1000;
            acc.add_accion();

            acc.fecha = "2020-12-22";
            acc.precio = 2000;
            acc.add_accion();

            acc.fecha = "2020-12-23";
            acc.precio = 3000;
            acc.add_accion();

            acc.fecha = "2020-12-24";
            acc.precio = 4000;
            acc.add_accion();

            acc.fecha = "2020-12-25";
            acc.precio = 5000;
            acc.add_accion();
            //fin agregar acciones

            Dictionary<string, double> acciones = acc.getAcciones();

            foreach (KeyValuePair<string, double> entry in acciones)
            {
                // do something with entry.Value or entry.Key
                Console.WriteLine(entry.Key+" <> "+entry.Value);
            }

            int years = 1;

            Console.WriteLine("El beneficio simple entre las fechas (2020-12-21 y 2020-12-23) es : " + cs.Beneficio("2020-12-21", "2020-12-23") + " % ");
            Console.WriteLine("El rendimiento anualizado entre las fechas (2020-12-21 y 2020-12-23) es : " + cs.Profit("2020-12-21", "2020-12-23", years) + " % ");
            Console.WriteLine("#FIN#");
            Console.ReadLine();
        }
    }
}
