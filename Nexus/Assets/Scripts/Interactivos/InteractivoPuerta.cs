using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractivoPuerta : ObjetoInteractuable2
{
    public float rotacionAbierto = 0;
    public float rotacionCerrado = 0;
    private bool abierto = false;

    public override void Activar() //esta es la accion real que se ejecuta cuando se interacta con la puerta
    {
        if (abierto)
        {
            transform.rotation = Quaternion.Euler(0, rotacionCerrado, 0);
            accionNombre = "Abrir puerta";
        }

        else
        {
            transform.rotation = Quaternion.Euler(0, rotacionAbierto, 0);
            accionNombre = "Cerrar puerta";
        }

        abierto = !abierto;
    }
}