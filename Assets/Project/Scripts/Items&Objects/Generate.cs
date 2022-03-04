using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour
{

    public GameObject objects;

    public float ObjectsSpawnXOffset = 10f;

    public float ObjectGenerateTimeInterval = 1.5f;

    private GameManager gm;

    public GameObject[] Items;

    public GameObject[] Enemies;

    float RandomYOffset;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();

        StartCoroutine("GenerateObjects");
        StartCoroutine("ItemGenerator",3);
        StartCoroutine("SpawnEnemies");
    }


    IEnumerator GenerateObjects()
    {
        
        while (gm.IsGameActive)
        {
            yield return new WaitForSeconds(ObjectGenerateTimeInterval);

            RandomYOffset = Random.Range(1f, -5f);
           
            Instantiate(objects, new Vector3(ObjectsSpawnXOffset, RandomYOffset, 0), transform.rotation);
        }
        
    }

    IEnumerator ItemGenerator()
    {
        while (gm.IsGameActive)
        {
            yield return new WaitForSeconds(7);
            int randomItem = Random.Range(0,2);
            int RandomCalc = Random.Range(-1, 1);

            Instantiate(Items[randomItem], new Vector3(ObjectsSpawnXOffset, RandomYOffset + RandomCalc, 0), transform.rotation);
            
        }
    }

    IEnumerator SpawnEnemies()
    {
        while (gm.IsGameActive) 
        {
            yield return new WaitForSeconds(ObjectGenerateTimeInterval * 4);

            int randomEnemy = Random.Range(0, 1);
            Instantiate(Enemies[randomEnemy], new Vector3(ObjectsSpawnXOffset, RandomYOffset + 1.5f, 0), transform.rotation);
        }
        
    }

}
