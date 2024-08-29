namespace ProgramasClase;

class Program
{
    static void Main(string[] args)
    {
        int n = 10;
        int tot_busquedas = 80;

        //BusquedaLocal busquedaLocal= new BusquedaLocal(n);    
        //busquedaLocal.run(tot_busquedas);

        int tot_busquedas_iteradas = 10;
        BusquedaLocalIterada busquedaLocalIterada= new BusquedaLocalIterada(n);
        busquedaLocalIterada.run(tot_busquedas_iteradas,tot_busquedas);

        

    }
}
