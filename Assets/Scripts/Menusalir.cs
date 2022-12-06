using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Menusalir : MonoBehaviour
{
    private Button boton;
    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(Salgo);
    }

    // Update is called once per frame
    void Salgo()
    {
        Application.Quit();
    }
}
