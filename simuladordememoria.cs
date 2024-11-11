using System;
using System.Collections.Generic;


class SimuladorMemoria
{
    private Queue<ProcesoBase> colaEspera = new Queue<ProcesoBase>();
    public int TamanoMemoria { get; private set; } // Agregar un atributo para el tamaño de la memoria

    // Constructor que acepta el tamaño de memoria
    public SimuladorMemoria(int tamanoMemoria)
    {
        TamanoMemoria = tamanoMemoria; // Inicializa el tamaño de la memoria
        Console.WriteLine($"Simulador de memoria creado con tamaño: {TamanoMemoria}");
    }

    public void AgregarProceso(ProcesoBase proceso)
    {
        colaEspera.Enqueue(proceso);
        Console.WriteLine($"Proceso {proceso.Id} agregado a la cola de espera");
    }

    public void DetenerProceso(ProcesoBase proceso)
    {
        proceso.Detener();
    }

    public void EliminarProceso(ProcesoBase proceso)
    {
        proceso.Eliminar();
    }
}
