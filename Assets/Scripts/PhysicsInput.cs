using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhysicsInput : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public float jumpForce = 1;
    public float maxForce = 10;
    public Rigidbody reggiebody;

    private float accumulatedForce = 0;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Jump"))
        {
            accumulatedForce = 0;

            //reggiebody.AddForce(Vector3.up * jumpForce);
            //Debug.Log("Jump Down");
        }
        else if (Input.GetButton("Jump"))
        {
            accumulatedForce += jumpForce + Time.deltaTime;

            if (accumulatedForce > maxForce)
            {
                accumulatedForce = maxForce;
            }

            //reggiebody.AddForce(Vector3.up * jumpForce * Time.deltaTime);
            //Debug.Log("Jump Hold");
        }
        else if (Input.GetButtonUp("Jump"))
        {
            reggiebody.AddForce(Vector3.up * accumulatedForce);

           //reggiebody.AddForce(Vector3.up * jumpForce);
           // Debug.Log("Jump up");
        }
    }
}
