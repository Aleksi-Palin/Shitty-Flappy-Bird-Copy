using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemScript : MonoBehaviour
{
    private Score scoreScript;
    public float Speed = 4;

    private GameManager gm;

    private void Start()
    {
        scoreScript = FindObjectOfType<Score>();
        gm = FindObjectOfType<GameManager>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Destroy(this.gameObject);
        }
        
    }

    private void FixedUpdate()
    {
        if (gm.IsGameActive)
        {
            transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);
        }
        
    }
}
