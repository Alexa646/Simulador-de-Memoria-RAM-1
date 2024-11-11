using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        // Proveer un tamaño de memoria al instanciar SimuladorMemoria
        SimuladorMemoria simulador = new SimuladorMemoria(100); // Por ejemplo, 100 MB

        // Crear procesos de usuario y sistema
        ProcesoUsuario usuario1 = new ProcesoUsuario(1, 5, 3);
        ProcesoSistema sistema1 = new ProcesoSistema(2, 10, 4);

        simulador.AgregarProceso(usuario1);
        simulador.AgregarProceso(sistema1);

        simulador.DetenerProceso(usuario1);
        simulador.EliminarProceso(sistema1);
    }
}