using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class VolverPerdiste : MonoBehaviour
{
    private Button boton;

    // Start is called before the first frame update
    void Start()
    {
        boton = GetComponent<Button>();
        boton.onClick.AddListener(volver);
    }

    // Update is called once per frame
    void volver()
    {
        SceneManager.LoadScene("Menu");
    }
}
