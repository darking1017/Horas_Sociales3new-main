using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GeneradorMonedas : MonoBehaviour
{
    public GameObject monedaPrefab;
    public float intervaloGeneracion = 1f; // Intervalo de tiempo entre generaciones

    private float tiempoUltimaGeneracion = 0f;
    private float minX, maxX, minY, maxY; // Variables para almacenar los límites de la pantalla

    void Start()
    {
        // Obtener los límites de la pantalla
        Vector2 esquinaInferiorIzquierda = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 esquinaSuperiorDerecha = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        minX = esquinaInferiorIzquierda.x;
        maxX = esquinaSuperiorDerecha.x;
        minY = esquinaInferiorIzquierda.y;
        maxY = esquinaSuperiorDerecha.y;

        // Iniciar el temporizador de generación
        tiempoUltimaGeneracion = Time.time;
    }

    void Update()
    {
        // Verificar si es momento de generar otra moneda
        if (Time.time - tiempoUltimaGeneracion >= intervaloGeneracion)
        {
            GenerarMoneda();
            tiempoUltimaGeneracion = Time.time;
        }
    }

    void GenerarMoneda()
    {
        // Calcular una posición aleatoria dentro de los límites de la pantalla
        Vector2 posicionAleatoria = new Vector2(Random.Range(minX, maxX), Random.Range(minY, maxY));

        // Instanciar una moneda en la posición aleatoria
        Instantiate(monedaPrefab, posicionAleatoria, Quaternion.identity);
    }
}