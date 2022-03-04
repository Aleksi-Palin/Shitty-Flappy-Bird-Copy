using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerController : MonoBehaviour
{
    private Rigidbody2D Rb2d;
    private BoxCollider2D Bc2d;

    private float FlyForce = 5f;

    private GameManager gm;

    private Score scoreScript;

    private bool HasPlayedEndAnim;

    private float ScreenWidth;

    public GameObject Ammo;
    private void Start()
    {
        gm = FindObjectOfType<GameManager>();
        Rb2d = GetComponent<Rigidbody2D>();
        Bc2d = GetComponent<BoxCollider2D>();
        scoreScript = FindObjectOfType<Score>();
        HasPlayedEndAnim = false;
        ScreenWidth = Screen.width;
    }

    private void Update()
    {
        //if left mouse click is pressed down, then apply upward force to player
        if (Input.GetMouseButtonDown(0) && gm.IsGameActive)
        {
            Rb2d.velocity = Vector2.zero;
            Rb2d.AddForce(Vector3.up * FlyForce, ForceMode2D.Impulse);
        }

        if (Input.GetKeyDown(KeyCode.Space) && gm.IsGameActive)
        {
            Instantiate(Ammo, transform.position , transform.rotation);
        }



        Vector2 screenPosition = Camera.main.WorldToScreenPoint(transform.position);
        if(screenPosition.y > Screen.height || screenPosition.y < 0)
        {
            gm.IsGameActive = false;
        }


        if(gm.IsGameActive == false)
        {
            Rb2d.velocity = Vector2.zero;

            if (!HasPlayedEndAnim)
            {
                Rb2d.AddForce(Vector3.up * 20, ForceMode2D.Impulse);
                HasPlayedEndAnim = true;
            }


            Rb2d.gravityScale = 45;
            GetComponent<BoxCollider2D>().enabled = false;

        }
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        
        if (collision.CompareTag("ObstacleDone"))
        {
            scoreScript.CurScore += 1;
        }

        if (collision.CompareTag("Item"))
        {
            scoreScript.ItemCount += 1;
        }

        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }
    }

}
