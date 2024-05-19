using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
 {
    // Velocidad de movimiento de la moneda
    public float velocity = 3f;

    // Rigidbody2D asociado a la moneda
    private Rigidbody2D rb2d;

    
    void Start()
    {
        // Obtener el componente Rigidbody2D
        rb2d = GetComponent<Rigidbody2D>();
        // Establecer la velocidad inicial de la moneda
        rb2d.velocity = Vector2.left * velocity;
    }

   
    void Update()
    {
        // Este método está vacío porque no hay lógica necesaria para el script
    }

    // Método que se llama cuando la moneda colisiona con otro collider
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si el objeto con el que colisiona la moneda tiene la etiqueta "Player"
        if (other.gameObject.tag == "Player")
        {
            // Destruir la moneda cuando colisiona con el jugador
            Destroy(gameObject);
        }
    }
}

