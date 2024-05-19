using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonMenu : MonoBehaviour
{
    // Este m�todo ser� llamado cuando el bot�n sea presionado
    public void GoToMenuPrincipal()
    {
        // Carga la escena del men� principal
        SceneManager.LoadScene("MenuInicial");
    }

}

