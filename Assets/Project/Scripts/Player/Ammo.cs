using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ammo : MonoBehaviour
{
    float Speed = 10;

    private void Start()
    {
        StartCoroutine("Destroy");
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position += new Vector3(Speed * Time.deltaTime, 0, 0);
    }

    

    IEnumerator Destroy()
    {
        yield return new WaitForSeconds(4);
        Destroy(this.gameObject);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            Destroy(collision.gameObject);
        }

    }
}
