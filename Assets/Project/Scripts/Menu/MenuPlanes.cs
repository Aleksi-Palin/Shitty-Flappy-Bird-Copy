using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuPlanes : MonoBehaviour
{
    private SpriteRenderer Sr;

    private bool IsFlipped;
    // Start is called before the first frame update
    void Start()
    {
        Sr = GetComponent<SpriteRenderer>();
        if(this.transform.position.x > 5)
        {
            Sr.flipX = true;
            IsFlipped = true;
        }

        float RandomSize = Random.Range(0.3f, 2f);

        gameObject.transform.localScale = new Vector2(RandomSize, RandomSize);
    }

    // Update is called once per frame
    void Update()
    {
        if (!IsFlipped)
        {
            transform.position += new Vector3(3 * Time.deltaTime, 0, 0);
        }
        else
        {
            transform.position -= new Vector3(3 * Time.deltaTime, 0, 0);
        }

        if(this.transform.position.x > 13)
        {
            Destroy(this.gameObject);
        } else if (this.transform.position.x < -13)
        {
            Destroy(this.gameObject);
        }

    }
}
