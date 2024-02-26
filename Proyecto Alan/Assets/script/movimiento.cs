using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public CharacterController controller;
    public float speed = 200f;

    // A�ade esta variable para la gravedad
    public Vector3 gravity = new Vector3(0, -9.81f, 0);

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        Vector3 movement = transform.right * x + transform.forward * z;

        // Comprueba si el personaje est� en contacto con el suelo
        if (controller.isGrounded)
        {
            // Si est� en el suelo, usa el movimiento normal
            controller.Move(movement * speed * Time.deltaTime);
        }
        else
        {
            // Si no est� en el suelo, aplica la gravedad
            controller.Move(movement * speed * Time.deltaTime + gravity * Time.deltaTime);
        }
    }
}