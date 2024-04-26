using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CartelOpciones : ObjetoInteractuable2
{
    private bool abierto = false;

    public override void Activar() //esta es la accion real que se ejecuta cuando se interacta con la puerta
    {
        accionNombre = "Activar opciones";
    }
}
