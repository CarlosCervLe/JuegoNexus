using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ControladorUI : MonoBehaviour
{
    public static ControladorUI Instancia;

    public GameObject grupoPromptInteraccion;
    public TextMeshProUGUI textoPromtp;
    // Start is called before the first frame update
    void Start()
    {
        Instancia = this;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MostrarInteractuable(ObjetoInteractuable1 obj)
    {
        //grupoPromptInteraccion.SetActive(true);
        // textoPromtp.text = obj.accionNombre;
        if (obj != null)
        {
            grupoPromptInteraccion.SetActive(true);
            textoPromtp.text = obj.accionNombre;
        }
        else
        {
            grupoPromptInteraccion.SetActive(false);
        }

    }
}
