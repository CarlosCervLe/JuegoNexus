using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GasController : MonoBehaviour
{
    // Referencia al sistema de partículas

    public GameObject particulas;
    public GameObject TextoGas;
    public Text textoGas;
    public BoxCollider boxCollider;

    void Start()
    {
        particulas.SetActive(false);
        TextoGas.SetActive(false);
    }

    public void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            PrenderParticulas();

        }
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            TextoGas.SetActive(true);
            textoGas.text = "Presiona E para interactuar";
        }
    }

    public void OnTriggerExit(Collider other)
    {
        TextoGas.SetActive(false);
    }

    public void PrenderParticulas()
    {
        particulas.SetActive (true);
        TextoGas.SetActive (false);
        boxCollider.enabled = false;
        StartCoroutine(Conteo());
    }

    public IEnumerator Conteo()
    {
        yield return new WaitForSeconds(7);

        particulas.SetActive(false);
        boxCollider.enabled = true;
    }
}