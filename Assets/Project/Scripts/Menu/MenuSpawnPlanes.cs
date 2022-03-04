using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuSpawnPlanes : MonoBehaviour
{
    public GameObject Plane;
    public float SpawnX;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("spawn", 1);
    }

    IEnumerator spawn()
    {
        while (true)
        {
            yield return new WaitForSeconds(1);
            float randomY = Random.Range(4, -4);
            Instantiate(Plane, new Vector3(SpawnX, randomY, 0),transform.rotation);
        }
    }

    
}
