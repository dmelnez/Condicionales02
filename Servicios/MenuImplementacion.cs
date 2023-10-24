using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales02.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int pedirNum()
        {
            int valor;
            Console.WriteLine("Introduzca un Valor");
            valor = Convert.ToInt32(Console.ReadLine());
            return valor;
        }

    }
}
