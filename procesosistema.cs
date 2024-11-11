using System;
using System.Collections.Generic;


class ProcesoSistema : ProcesoBase
{
    public ProcesoSistema(int id, int tiempoEjecucion, int tamanoMemoria)
        : base(id, tiempoEjecucion, tamanoMemoria, "en espera", "naranja") // Aquí se pasan los argumentos necesarios
    {
        // El color se establece en el constructor base
    }

    public override void Eliminar()
    {
        base.Eliminar();
        Console.WriteLine($"Proceso de sistema {Id} eliminado.");
    }
}