using Condicionales02;
using Condicionales02.Servicios;

class Program
{

    static void Main(String[] args)
    {

        MenuInterfaz mi = new MenuImplementacion();
        int valor01 = mi.pedirNum();
        int valor02 = mi.pedirNum();

      Console.WriteLine(valor01 * valor01 == valor02);
    }
}
