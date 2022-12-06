using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public CharacterController controller;

    public float Velocidad;
    public float velRotacion;

    private bool Adelante;
    private bool Atras;
    private bool Derecha;
    private bool Izquierda;
    private bool rotDerecha;
    private bool rotIzquierda;

    void Update()
    {
        if (Adelante == true)
        {
            controller.Move(transform.forward * Velocidad * Time.deltaTime);
        }

        if (Atras == true)
        {
            controller.Move(-transform.forward * Velocidad * Time.deltaTime);
        }

        if (Derecha == true)
        {
            controller.Move(transform.right * Velocidad * Time.deltaTime);
        }

        if (Izquierda == true)
        {
            controller.Move(-transform.right * Velocidad * Time.deltaTime);
        }

        if (rotDerecha == true)
        {
            transform.Rotate(-Vector3.up * velRotacion * Time.deltaTime);
        }

        if (rotIzquierda == true)
        {
            transform.Rotate(Vector3.up * velRotacion * Time.deltaTime);
        }

    }
    public void HaciaAdelante()
    {
        Adelante = true;
    }
    public void HaciaAtras()
    {
        Atras = true;
    }
    public void HaciaIzquierda()
    {
        Izquierda = true;
    }
    public void HaciaDerecha()
    {
        Derecha = true;
    }
    public void RotacionDerecha()
    {
        rotDerecha = true;
    }
    public void RotacionIzquierda()
    {
        rotIzquierda = true;
    }

    public void sinfuncion()
    {
        Adelante = false;
        Atras = false;
        Derecha = false;
        Izquierda = false;
        rotDerecha = false;
        rotIzquierda = false;
    }
}
