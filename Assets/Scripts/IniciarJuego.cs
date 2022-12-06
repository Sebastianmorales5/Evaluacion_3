using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class IniciarJuego : MonoBehaviour
{
    private Button boton;

    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(pruebamenu);
    }

    // Update is called once per frame
    void pruebamenu()
    {
        SceneManager.LoadScene("Juego");
    }
}
