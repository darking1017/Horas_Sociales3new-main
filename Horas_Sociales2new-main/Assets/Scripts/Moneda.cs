using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Moneda : MonoBehaviour
{ 
    // Aqu� puedes agregar cualquier l�gica adicional para el comportamiento de la moneda, como aumentar el puntaje del jugador, reproducir un sonido, etc.

    void OnTriggerEnter2D(Collider2D other)
    {
        // Verificar si la moneda ha entrado en contacto con la nave
        if (other.CompareTag("Player"))
        {
            GameObject.FindObjectOfType<Jugador>().PuntosMonedas();
            // Destruir la moneda
            Destroy(gameObject);

            // Aqu� puedes agregar cualquier l�gica adicional, como aumentar el puntaje del jugador, reproducir un sonido, etc.
            Debug.Log("�Moneda recolectada!");
        }
    }
}