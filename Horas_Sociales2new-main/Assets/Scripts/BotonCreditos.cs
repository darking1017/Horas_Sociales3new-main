using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BotonCreditos : MonoBehaviour
{
    // Este m�todo ser� llamado cuando el bot�n sea presionado
    public void LoadCredits()
    {
        // Carga la escena de cr�ditos
        // Reemplaza "Credits" con el nombre de tu escena de cr�ditos
        SceneManager.LoadScene("Creditos");
    }
}
