using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class NewJugador : MonoBehaviour
{
    public static string jugadorenpantalla;
    Text Player;
    void Start()
    {
        Player = GetComponent<Text>();
    }
    void Update()
    {
        Player.text = "Jugador: " + jugadorenpantalla;
    }
}
