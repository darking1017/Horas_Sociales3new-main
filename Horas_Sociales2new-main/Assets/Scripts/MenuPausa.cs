using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuPausa : MonoBehaviour
{
    // Referencias a los objetos de botón de pausa y menú de pausa en el inspector de Unity
    [SerializeField] private GameObject botonPausa;
    [SerializeField] private GameObject menuPausa;

    // Variable para rastrear si el juego está pausado o no
    private bool JuegoPausado;

    // Método que se llama en cada frame
    private void Update()
    {
        // Si se presiona la tecla Escape
        if (Input.GetKeyUp(KeyCode.Escape))
        {
            // Si el juego no está pausado
            if (!JuegoPausado)
            {
                // Llama al método Reanudar para reanudar el juego
                Reanudar();
            }
            else
            {
                // Llama al método pausa para pausar el juego
                pausa();
            }
        }
    }

    // Método para pausar el juego
    public void pausa()
    {
        // Establece que el juego está pausado
        JuegoPausado = true;
        // Detiene el tiempo en el juego
        Time.timeScale = 0f;
        // Desactiva el botón de pausa y activa el menú de pausa
        botonPausa.SetActive(false);
        menuPausa.SetActive(true);
    }

    // Método para reanudar el juego
    public void Reanudar()
    {
        // Establece que el juego no está pausado
        JuegoPausado = false;
        // Restaura el tiempo en el juego a su velocidad normal
        Time.timeScale = 1f;
        // Activa el botón de pausa y desactiva el menú de pausa
        botonPausa.SetActive(true);
        menuPausa.SetActive(false);
    }

    // Método para reiniciar el juego
    public void Reiniciar()
    {
        // Restaura el tiempo en el juego a su velocidad normal
        Time.timeScale = 1f;
        // Carga de nuevo la escena actual
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    // Método para cerrar el juego
    public void Cerrar()
    {
        // Cierra la aplicación
        Debug.Log("Cerrando juego");
        Application.Quit();
    }
}
