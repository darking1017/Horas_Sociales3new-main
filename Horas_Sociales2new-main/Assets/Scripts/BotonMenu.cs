using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonMenu : MonoBehaviour
{
    // Este método será llamado cuando el botón sea presionado
    public void GoToMenuPrincipal()
    {
        // Carga la escena del menú principal
        SceneManager.LoadScene("MenuInicial");
    }

}

