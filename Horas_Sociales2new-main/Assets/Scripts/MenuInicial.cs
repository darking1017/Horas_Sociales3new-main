using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuInicial : MonoBehaviour
{
    // Este método se llama cuando se presiona el botón "Jugar"
    public void jugar()
    {
        // Cargar la siguiente escena en la secuencia
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    // Este método se llama cuando se presiona el botón "Salir"
    public void salir()
    {
        // Imprimir un mensaje de depuración
        Debug.Log("Salir...");

        // Salir de la aplicación
        Application.Quit();
    }
}
