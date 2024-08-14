using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    public float speed = 2f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        //destroy every x secs
        Destroy(gameObject, 15f);

    }

    // Update is called once per frame
    void Update()
    {
        // Move the enemy to the left
        rb.velocity = new Vector2(-speed, rb.velocity.y);
    }
}
