using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float playerSpeed;
    private CharacterController player;
    private Animator miAnimador;

    public float gravedad = 9.8f;

    void Start()
    {
        player = GetComponent<CharacterController>();
        miAnimador = GetComponent<Animator>();
    }

    void Update()
    {
        float horizMove = Input.GetAxis("Horizontal");
        float verticMove = Input.GetAxis("Vertical");
        Vector3 moveDirection = transform.right * horizMove + transform.forward * verticMove;
        moveDirection.Normalize();

        player.Move(moveDirection * playerSpeed * Time.deltaTime);

        Animaciones(horizMove, verticMove);
        Gravedad();
    }

    void Animaciones(float horizMove, float verticMove)
    {
        miAnimador.SetFloat("MovLat", horizMove);
        miAnimador.SetFloat("MovFront", verticMove);
    }

    void Gravedad()
    {
        if (!player.isGrounded)
        {
            player.Move(Vector3.down * gravedad * Time.deltaTime);
        }
    }
}