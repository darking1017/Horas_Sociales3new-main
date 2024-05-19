using System.Collections;
using System.Collections.Generic;
using TMPro; // Importar La libreria de unity para el TextMeshProUGUI
using UnityEngine;

public class Jugador : MonoBehaviour
{
    // Variable para almacenar la cantidad de puntos de monedas
    private float puntosMonedas = 0;

    // Referencia al componente TextMeshProUGUI para mostrar los puntos de monedas
    public TextMeshProUGUI textMeshMonedas;

    // Método para aumentar los puntos de monedas y actualizar el texto en pantalla
    public void PuntosMonedas()
    {
        // Incrementar los puntos de monedas
        puntosMonedas++;

        // Actualizar el texto en el componente TextMeshProUGUI para reflejar los nuevos puntos de monedas
        textMeshMonedas.text = puntosMonedas.ToString();
    }


    void Start()
    {
        // Este método está vacío porque no hay lógica necesaria para el script
    }


    void Update()
    {
        // Este método está vacío porque no hay lógica necesaria para el script
    }

}
