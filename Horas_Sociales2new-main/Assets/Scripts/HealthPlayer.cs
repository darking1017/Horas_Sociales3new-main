using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HealthPlayer : MonoBehaviour
{
    // Variables públicas para la salud, la salud máxima y el estado de vida
    public int health;
    public int maxHealth;
    public bool imAlive;

    // Método que se llama al inicio
    private void Start()
    {
        // Establece la salud inicial como la salud máxima al inicio del juego
        health = maxHealth;
    }

    // Método para recibir daño
    void RecieveDamage(int damage)
    {
        // Si el objeto está vivo
        if (imAlive)
        {
            // Si la salud es mayor que 0
            if (health > 0)
            {
                // Reduce la salud
                health--;

                // Llama a una función para actualizar la visualización de la salud
                GetComponent<Vidas>().RemoveHearts(imAlive, health, maxHealth);

                // Si la salud llega a 0, marca al objeto como muerto y llama al método GameOver
                if (health == 0)
                {
                    imAlive = false;
                    GameOver();
                }
            }

            // Si la salud es menor o igual a 0, marca al objeto como muerto y llama a GameOver
            if (health <= 0)
            {
                GameOver();
                imAlive = false;
                GetComponent<Vidas>().RemoveHearts(imAlive, health, maxHealth);
            }
        }
    }

    // Método para manejar el final del juego
    public void GameOver()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }

    // Método que se llama cuando el objeto colisiona con un "Destroyer"
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Si el objeto colisiona con un objeto que tiene la etiqueta "Enemy"
        if (other.gameObject.CompareTag("Enemy"))
        {
            // Registra la colisión con un enemigo y recibe un punto de daño
            Debug.Log("Collision con enemigo");
            RecieveDamage(1);
        }
    }
}
