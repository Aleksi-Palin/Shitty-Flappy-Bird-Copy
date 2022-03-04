using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{

    public float Speed = 4;

    private GameManager gm;

    private Rigidbody2D Rb2d;

    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        Rb2d = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        if(this.transform.position.x < -40)
        {
            Destroy(this.gameObject);
        }

        if (gm.IsGameActive)
        {
            transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);
            
        }
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        gm.IsGameActive = false;
    }



}
