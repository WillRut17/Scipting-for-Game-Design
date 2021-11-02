using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D : MonoBehaviour
{
    public Rigidbody2D reggiebody;
    public float speed;

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");

        Vector2 movement = Vector2.zero;

        movement.x = x * speed * Time.deltaTime;
        movement.y = reggiebody.velocity.y;
        reggiebody.velocity = movement;
    }
}
