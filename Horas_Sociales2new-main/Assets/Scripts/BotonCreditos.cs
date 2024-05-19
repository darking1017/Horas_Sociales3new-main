using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCreditos : MonoBehaviour
{
    // Este método será llamado cuando el botón sea presionado
    public void LoadCredits()
    {
        // Carga la escena de créditos
        // Reemplaza "Credits" con el nombre de tu escena de créditos
        SceneManager.LoadScene("Creditos");
    }
}
