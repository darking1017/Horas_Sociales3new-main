using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoMapa : MonoBehaviour
{
    // Velocidad de movimiento del fondo en unidades por segundo
    [SerializeField] private Vector2 velocidadMovimiento;

    // Desplazamiento actual del fondo
    private Vector2 offset;

    // Material del fondo
    private Material fondo;

    // Método llamado cuando se despierta el objeto
    public void Awake()
    {
        // Obtener el material del fondo del componente SpriteRenderer
        fondo = GetComponent<SpriteRenderer>().material;
    }

    public void Update()
    {
        // Calcular el desplazamiento basado en la velocidad de movimiento y el tiempo transcurrido desde el último frame
        offset = velocidadMovimiento * Time.deltaTime;

        // Aplicar el desplazamiento al offset de la textura del fondo
        fondo.mainTextureOffset += offset;
    }
}

