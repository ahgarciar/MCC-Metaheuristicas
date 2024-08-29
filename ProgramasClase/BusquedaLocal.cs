namespace ProgramasClase;

public class BusquedaLocal {

    private Random rnd;
    private int[] solucion;

    public BusquedaLocal(int n){
        int i;

        solucion = new int[n];

        //int []optima_local;

        rnd = new Random(5);

        ///generacion de la solucional inicial  - aleatoria
        for (i = 0; i < n; i++)
        {
            solucion[i] = rnd.Next(2); //0 , 1
        }
        
    }

    public void run(int tot_busquedas) {
       
        busqueda_local(solucion, tot_busquedas); //80 veces a repetir la busqueda local

    }

    public void busqueda_local(int[] solucion, int max_iteraciones)
    {

        int cont = 0;
        int vo_mejor_actual = funcion_objetivo(solucion);
        int[] solucion_vecina;
        int vo_vecina;
        while (cont < max_iteraciones)
        {

            solucion_vecina = genera_vecina(solucion);

            vo_vecina = funcion_objetivo(solucion_vecina);

            if (vo_vecina > vo_mejor_actual)
            {
                for (int i = 0; i < solucion.Length; i++)
                {
                    solucion[i] = solucion_vecina[i];
                }
                vo_mejor_actual = vo_vecina;
                ////////////////////////////////////////////////////////////
                //IMPRIMIR LA MEJOR SOLUCION ACTUAL....
                Console.WriteLine("Mejor Solucion Actual:");
                imprimir(solucion);
                Console.WriteLine("Mejor VO Actual:");
                Console.WriteLine(vo_mejor_actual + "\n\n");
                ////////////////////////////////////////////////////////////
            }

            cont++; 
        }

                ////////////////////////////////////////////////////////////
                //IMPRIMIR LA MEJOR SOLUCION....
                Console.WriteLine("Mejor Solucion Encontrada:");
                imprimir(solucion);
                Console.WriteLine("Mejor VO Encontrado:");
                Console.WriteLine(vo_mejor_actual);
                ////////////////////////////////////////////////////////////

    }

    public void imprimir(int[] vector){
        for (int i = 0;i<vector.Length; i++){
            Console.Write(vector[i] + "\t");
        }
        Console.WriteLine();
    }

    public int funcion_objetivo(int[] vector)
    {
        int vo = 0;  //valor objetivo  --- fitness
        for (int i = 0; i < vector.Length; i++)
        {
            vo += vector[i];
        }
        return vo;
    }

    public int[] genera_vecina(int[] solucion)
    {
        int[] nueva_solucion = new int[solucion.Length];
        //copiar la original en la vecina
        for (int i = 0; i < solucion.Length; i++)
        {
            nueva_solucion[i] = solucion[i]; //
        }

        int index_gen_a_mutar = rnd.Next(solucion.Length);

        //mutacion uniforme de un gen
        if (rnd.Next(100) > 50)
        {
            nueva_solucion[index_gen_a_mutar] = 1;
        }
        else
        {
            nueva_solucion[index_gen_a_mutar] = 0;
        }

        return nueva_solucion;
    }

    public int[] genera_vecina_perturbada(int[] solucion)
    {
        int[] nueva_solucion = new int[solucion.Length];
        //copiar la original en la vecina
        for (int i = 0; i < solucion.Length; i++)
        {
            nueva_solucion[i] = solucion[i]; //
        }

        //mutacion uniforme de la solucion
        for (int i = 0; i < solucion.Length; i++)
        {
            if (rnd.Next(100) > 50)
            {
                nueva_solucion[i] = 1;
            }
            else
            {
                nueva_solucion[i] = 0;
            }
        }

        return nueva_solucion;
    }


}