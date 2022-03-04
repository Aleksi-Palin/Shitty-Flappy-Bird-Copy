using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float Speed = 4;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position -= new Vector3(Speed * Time.deltaTime, 0, 0);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        print("bullet hitted");
        if (collision.CompareTag("Bullet"))
        {
            Destroy(this.gameObject);
        }
    }

}
