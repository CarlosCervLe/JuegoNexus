using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class CodigoController : MonoBehaviour
{
    [SerializeField] private Text Ans;
    private string Answer = "1234";

    private MovMouse movMouse;
    public PanelCodigo panelCodigo;
    public BoxCollider boxCollider;
    public Transform puerta;

    public void Start()
    {
        panelCodigo = GameObject.FindGameObjectWithTag("KeyPad").GetComponent<PanelCodigo>();
        boxCollider = GameObject.FindGameObjectWithTag("KeyPad").GetComponent<BoxCollider>();
        puerta = GameObject.FindGameObjectWithTag("Puerta").GetComponent<Transform>();
        movMouse = GameObject.FindGameObjectWithTag("Player").GetComponent<MovMouse>();
    }

    public void Numero(int numero)
    {
        Ans.text += numero.ToString();
    }

    public void Ejecutar()
    {
        if (Ans.text == Answer)
        {
            Ans.text = "Valido";
            puerta.rotation = Quaternion.Euler(0, 90, 0);
            StartCoroutine(EsperarYDesactivar());
        }
        else
        {
            Ans.text = "Incorrecto";
        }
    }

    private IEnumerator EsperarYDesactivar()
    {
        yield return new WaitForSeconds(1.5f);

        panelCodigo.KeyCode.SetActive(false);
        movMouse.velocidadRot = 5;
        boxCollider.enabled = false;
    }

    public void reiniciar()
    {
        Ans.text = "";
    }
}