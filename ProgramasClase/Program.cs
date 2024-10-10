namespace ProgramasClase;

class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int tot_busquedas = 80;

        //BusquedaLocal busquedaLocal= new BusquedaLocal(n);    
        //busquedaLocal.run(tot_busquedas);

        //int tot_busquedas_iteradas = 10;
        //BusquedaLocalIterada busquedaLocalIterada= new BusquedaLocalIterada(n);
        //busquedaLocalIterada.run(tot_busquedas_iteradas,tot_busquedas);

        //Console.WriteLine("Recocido Simulado:");
        int tot_ejecuciones_RC = 50;
        double TemperaturaInicial = 100; 
        double alfa = 0.95;
        RecocidoSimulado SA= new RecocidoSimulado(n, TemperaturaInicial);
        SA.run(tot_ejecuciones_RC,tot_busquedas, alfa);

    }
}
