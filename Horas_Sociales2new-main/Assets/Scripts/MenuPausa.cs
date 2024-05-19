using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    // Referencias a los objetos de bot�n de pausa y men� de pausa en el inspector de Unity
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    // Variable para rastrear si el juego est� pausado o no
    private bool JuegoPausado;

    // M�todo que se llama en cada frame
    private void Update()
    {
        // Si se presiona la tecla Escape
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // Si el juego no est� pausado
            if (!JuegoPausado)
            {
                // Llama al m�todo Reanudar para reanudar el juego
                Reanudar();
            }
            else
            {
                // Llama al m�todo pausa para pausar el juego
                pausa();
            }
        }
    }

    // M�todo para pausar el juego
    public void pausa()
    {
        // Establece que el juego est� pausado
        JuegoPausado = true;
        // Detiene el tiempo en el juego
        Time.timeScale = 0f;
        // Desactiva el bot�n de pausa y activa el men� de pausa
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    // M�todo para reanudar el juego
    public void Reanudar()
    {
        // Establece que el juego no est� pausado
        JuegoPausado = false;
        // Restaura el tiempo en el juego a su velocidad normal
        Time.timeScale = 1f;
        // Activa el bot�n de pausa y desactiva el men� de pausa
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    // M�todo para reiniciar el juego
    public void Reiniciar()
    {
        // Restaura el tiempo en el juego a su velocidad normal
        Time.timeScale = 1f;
        // Carga de nuevo la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // M�todo para cerrar el juego
    public void Cerrar()
    {
        // Cierra la aplicaci�n
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
}
