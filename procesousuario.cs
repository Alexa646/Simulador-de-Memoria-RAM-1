using System;
using System.Collections.Generic;

class ProcesoUsuario : ProcesoBase
{
    public ProcesoUsuario(int id, int tiempoEjecucion, int tamanoMemoria)
        : base(id, tiempoEjecucion, tamanoMemoria, "en espera", "verde") // Aquí se pasan los argumentos necesarios
    {
        // El color se establece en el constructor base
    }

    public override void Detener()
    {
        base.Detener();
        Console.WriteLine($"Proceso de usuario {Id} detenido con éxito.");
    }
}
