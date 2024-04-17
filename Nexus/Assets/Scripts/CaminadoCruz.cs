using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaminadoCruz : MonoBehaviour
{
    private Rigidbody cuerpo;
    private Animator miAnimador;
    public float velocidadMovi;

    void Start()
    {
        cuerpo = GetComponent<Rigidbody>();
        miAnimador = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        float horiz = Input.GetAxis("Horizontal");
        float verti = Input.GetAxis("Vertical");

        miAnimador.SetFloat("MovLat", horiz);
        miAnimador.SetFloat("MovFront", verti);

        Vector3 direc = (transform.forward * verti + transform.right * horiz).normalized;
        cuerpo.velocity = direc * velocidadMovi;

    }
}