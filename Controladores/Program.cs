using Condicionales02;
using Condicionales02.Servicios;

/// <summary>
/// Clase Principal por la cual el programa se lanza
/// <autor>24/10/2023</autor>
/// </summary>


class Program
{
    /// <summary>
    /// Metodo por el cual la aplicacion se inicializa
    /// <autor>24/10/2023</autor>
    /// </summary>
    /// <param name="args"></param>
    
    static void Main(String[] args)
    {



        MenuInterfaz mi = new MenuImplementacion();
        int valor01 = mi.pedirNum();
        int valor02 = mi.pedirNum();

      Console.WriteLine(valor01 * valor01 == valor02);
    }
}
