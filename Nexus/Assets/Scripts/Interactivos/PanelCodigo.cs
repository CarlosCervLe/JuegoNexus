using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PanelCodigo : MonoBehaviour
{
    public GameObject KeyCode;
    private MovMouse movMouse;

    // Start is called before the first frame update
    void Start()
    {
        KeyCode.SetActive(false);
        movMouse = GameObject.FindGameObjectWithTag("Player").GetComponent<MovMouse>();
    }

    public void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            KeyCode.SetActive(true);
            Cursor.visible = true;
            movMouse.velocidadRot = 0;
        }
    }

    public void OnTriggerExit(Collider other)
    {
        KeyCode.SetActive(false);
        Cursor.visible = false;
        movMouse.velocidadRot = 5;
    }
}
