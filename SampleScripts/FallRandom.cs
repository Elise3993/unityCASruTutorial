using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallRandom : MonoBehaviour
{
    void Update()
    {
        if (this.transform.position.y < - 5.0)
        {
            float x = Random.Range(-9.0f,9.0f);
            float y = 5.0f;

            this.transform.position = new Vector3(x,y,0);

            Rigidbody2D rb = GetComponent<Rigidbody2D>();
            rb.velocity = new Vector3(0, 0, 0);
        }
    }
}
