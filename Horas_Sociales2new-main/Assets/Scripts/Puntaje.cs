using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Puntaje : MonoBehaviour
{
    // Variable para almacenar los puntos
    private float puntos;

    // Referencia al componente TextMeshProUGUI para mostrar los puntos
    private TextMeshProUGUI textMesh;

    
    private void Start()
    {
        // Obtener la referencia al componente TextMeshProUGUI adjunto al mismo GameObject
        textMesh = GetComponent<TextMeshProUGUI>();
    }

    
    private void Update()
    {
        // Incrementar los puntos con el tiempo transcurrido desde el último frame
        puntos += Time.deltaTime;

        // Actualizar el texto en el componente TextMeshProUGUI para reflejar los nuevos puntos
        textMesh.text = puntos.ToString("0"); // Mostrar los puntos como un número entero sin decimales
    }
}
