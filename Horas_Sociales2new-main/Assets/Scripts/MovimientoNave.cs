using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoNave : MonoBehaviour
{
    public float velocidad = 5f; // Velocidad de movimiento de la nave

    private Rigidbody2D rb;
    private SpriteRenderer spriteRenderer;
    private float minX, maxX, minY, maxY; // Variables para almacenar los límites de la pantalla

    void Start()
    {
        // Obtener el componente Rigidbody2D de la nave
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();

        // Definir los límites de la pantalla
        // Convertir las esquinas de la pantalla de la vista de la cámara en coordenadas del mundo
        Vector2 esquinaInferiorIzquierda = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 esquinaSuperiorDerecha = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));
        // Asignar los límites de la pantalla
        // Definir el límite izquierdo de la pantalla
        minX = esquinaInferiorIzquierda.x + spriteRenderer.size.x / 2;

        // Definir el límite derecho de la pantalla
        maxX = esquinaSuperiorDerecha.x - spriteRenderer.size.x / 2;

        // Definir el límite inferior de la pantalla
        minY = esquinaInferiorIzquierda.y + spriteRenderer.size.y / 2;

        // Definir el límite superior de la pantalla
        maxY = esquinaSuperiorDerecha.y - spriteRenderer.size.y / 2;
    }

    void Update()
    {
        // Obtener la entrada del teclado
        float movimientoHorizontal = Input.GetAxis("Horizontal");
        float movimientoVertical = Input.GetAxis("Vertical");

        // Calcular el vector de movimiento
        Vector2 movimiento = new Vector2(movimientoHorizontal, movimientoVertical);

        // Aplicar el movimiento a la nave
        rb.velocity = movimiento * velocidad;

        // Limitar la posición de la nave dentro de los límites de la pantalla
        // Obtener la posición actual de la nave
        Vector2 posicionActual = transform.position;
        // Limitar la coordenada x dentro de los límites minX y maxX
        posicionActual.x = Mathf.Clamp(posicionActual.x, minX, maxX);
        // Limitar la coordenada y dentro de los límites minY y maxY
        posicionActual.y = Mathf.Clamp(posicionActual.y, minY, maxY);
        // Asignar la posición limitada a la nave
        transform.position = posicionActual;
    }
}