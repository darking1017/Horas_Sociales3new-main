using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Este m�todo se llama cuando se presiona el bot�n "Jugar"
    public void jugar()
    {
        // Cargar la siguiente escena en la secuencia
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Este m�todo se llama cuando se presiona el bot�n "Salir"
    public void salir()
    {
        // Imprimir un mensaje de depuraci�n
        Debug.Log("Salir...");

        // Salir de la aplicaci�n
        Application.Quit();
    }
}
