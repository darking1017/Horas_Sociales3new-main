using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorController : MonoBehaviour
{
    // Prefab del enemigo a generar
    public GameObject enemyPrefab;

    // Tiempo entre generaci�n de enemigos
    public float generatorTimer = 1.75f;

    // Posici�n en el eje X donde se generar�n los enemigos
    public float spawnXPosition;

    // Altura m�nima y m�xima donde se generar�n los enemigos en el eje Y
    public float minYpos, maxYpos;

    
    void Start()
    {
        // Llamar repetidamente a la funci�n CreateEnemy despu�s de 5 segundos, con un intervalo de generatorTimer segundos
        InvokeRepeating("CreateEnemy", 5, generatorTimer);
    }

   
    void Update()
    {
        // Este m�todo est� vac�o porque no hay l�gica necesaria para el script
    }

    // M�todo para crear un enemigo
    void CreateEnemy()
    {
        // Instanciar un nuevo enemigo a partir del prefab
        GameObject pref = Instantiate(enemyPrefab);

        // Generar una posici�n aleatoria en el eje Y dentro del rango minYpos y maxYpos
        float y = Random.Range(minYpos, maxYpos);

        // Establecer la posici�n del enemigo en spawnXPosition en el eje X y la posici�n aleatoria en el eje Y
        pref.transform.position = new Vector3(spawnXPosition, y, 0);
    }

    // M�todo para comenzar la generaci�n de enemigos
    public void StartGenerator()
    {
        // Llamar repetidamente a la funci�n CreateEnemy desde el inicio, con un intervalo de generatorTimer segundos
        InvokeRepeating("CreateEnemy", 0f, generatorTimer);
    }

    // M�todo para cancelar la generaci�n de enemigos
    // Si clean es true, tambi�n destruye todos los enemigos existentes
    public void CancelGenerator(bool clean = false)
    {
        // Cancelar las llamadas repetidas a la funci�n CreateEnemy
        CancelInvoke("CreateEnemy");

        // Si clean es true, encontrar todos los objetos con la etiqueta "Enemy" y destruirlos
        if (clean)
        {
            GameObject[] allEnemies = GameObject.FindGameObjectsWithTag("Enemy");
            foreach (GameObject enemy in allEnemies)
            {
                Destroy(enemy);
            }
        }
    }

}
