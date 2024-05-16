using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjetoInteractuable2 : MonoBehaviour
{

    public string accionNombre;
    //public UnityAction<object> alActivar; 
    public abstract void Activar(); //promesa de accion que se va a realizar, se define e una clase que hereda esta
    private bool enContacto = false;

    private void Update()
    {
        if (Input.GetButtonDown("Fire1") && enContacto)
        {
            //si se presiobnael boton y esta en contacto, ejec uto la accion abstracta
            Activar();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }

        ControladorUI1.Instancia.MostrarInteractuable(this);
        enContacto = true;
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag != "Player")
        {
            return;
        }


        ControladorUI1.Instancia.MostrarInteractuable(null);
        enContacto = false;
    }
}