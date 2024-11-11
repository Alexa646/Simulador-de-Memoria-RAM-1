using System;
using System.Collections.Generic;


class ProcesoBase
{
    public int Id { get; set; } //identificador unico para el proceso
    public int TiempoEjecucion { get; set; }//Tiempo que el proceso necesita para ejecutarse 
    public int TamanoMemoria { get; set; }//Tamaño de memoria requerido
    public  string Estado { get; set; }//Estado del proceso; en espera, ejecucioon, detenido, etc.
    public string Color { get; set; }//Color para repreentar visualmente el proceso


    public ProcesoBase(int id, int tiempoEjecucion, int tamanoMemoria, string estado, string color)
    {
        Id = id;
        TiempoEjecucion = tiempoEjecucion;
        TamanoMemoria = tamanoMemoria;
        Estado = estado;
        Color = "azul";
    }

    public virtual void Detener()
    {
        Estado = "detenido";
        Color = "amarillo";//cambia el color cuando el proceso esta detenido
        Console.WriteLine($"Proceso{Id} detenido.");
    }

    //metodo con el que eliminamos el proceso
    public virtual void Eliminar()
    {
        Estado = "eliminado";
        Console.WriteLine($"Proceso {Id} eliminado");
    }
}