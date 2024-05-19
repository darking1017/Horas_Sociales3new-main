using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vidas : MonoBehaviour
{
    public GameObject[] heartsArray;

    //se usa cuando el jugador recupera vida 
    public void RecoverHearts(int health)
    {
        for (int u = 0; u <= health - 1; u++)
        {
            heartsArray[u].SetActive(true);
        }
    }
    //se usa cuando el jugador recibe daño
    public void RemoveHearts(bool imAlive, int health, int maxHealth)
    {
        if (imAlive)
        {
            for (int u = health; u < maxHealth; u++)
            {
                heartsArray[health].SetActive(false);

            }
        }
        else //desactivar los corazones
        {
            for (int i = 0; i < heartsArray.Length; i++)
            {
                heartsArray[i].SetActive(false);

            }
        }
    }
    //se usa para cuando agranda la cantidad de corazones maximas
    public void GenerateNewHeart(int health)
    {
        for (int u = 0; u <= health - 1; u++)
        {
            heartsArray[u].SetActive(true);
        }
    }


    //para se usa para que te active los corazones necesarios 
    //nota: estos tienen que estar creados ya como objetos en el juego antes de darle play al juego
    public void GenerateHeartsInStart(int health, int maxHealth)
    {
        if (maxHealth <= heartsArray.Length)
        {
            for (int i = health; i < heartsArray.Length; i++)
            {
                heartsArray[i].SetActive(false);
            }
        }
        else
        {
            for (int i = 0; i < heartsArray.Length; i++)
            {
                heartsArray[i].SetActive(true);
            }
        }
    }
}
