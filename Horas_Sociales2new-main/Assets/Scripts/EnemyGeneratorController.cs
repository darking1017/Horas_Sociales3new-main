using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyGeneratorController : MonoBehaviour
{
    // Prefab del enemigo a generar
    public GameObject enemyPrefab;

    // Tiempo entre generación de enemigos
    public float generatorTimer = 1.75f;

    // Posición en el eje X donde se generarán los enemigos
    public float spawnXPosition;

    // Altura mínima y máxima donde se generarán los enemigos en el eje Y
    public float minYpos, maxYpos;

    
    void Start()
    {
        // Llamar repetidamente a la función CreateEnemy después de 5 segundos, con un intervalo de generatorTimer segundos
        InvokeRepeating("CreateEnemy", 5, generatorTimer);
    }

   
    void Update()
    {
        // Este método está vacío porque no hay lógica necesaria para el script
    }

    // Método para crear un enemigo
    void CreateEnemy()
    {
        // Instanciar un nuevo enemigo a partir del prefab
        GameObject pref = Instantiate(enemyPrefab);

        // Generar una posición aleatoria en el eje Y dentro del rango minYpos y maxYpos
        float y = Random.Range(minYpos, maxYpos);

        // Establecer la posición del enemigo en spawnXPosition en el eje X y la posición aleatoria en el eje Y
        pref.transform.position = new Vector3(spawnXPosition, y, 0);
    }

    // Método para comenzar la generación de enemigos
    public void StartGenerator()
    {
        // Llamar repetidamente a la función CreateEnemy desde el inicio, con un intervalo de generatorTimer segundos
        InvokeRepeating("CreateEnemy", 0f, generatorTimer);
    }

    // Método para cancelar la generación de enemigos
    // Si clean es true, también destruye todos los enemigos existentes
    public void CancelGenerator(bool clean = false)
    {
        // Cancelar las llamadas repetidas a la función CreateEnemy
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
