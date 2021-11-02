using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeAnimator : MonoBehaviour
{
    public Animator animator;
 
    // Start is called before the first frame update
    void Start()
    {
        animator = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxis("Horizontal");
        float y = Input.GetAxis("Vertical");

        if (x != 0)
        {
            animator.SetInteger("MovementType", 1);
        }
        else if (y != 0)
        {
            animator.SetInteger("MovementType", 2);
        }
        else
        {
            animator.SetInteger("MovementType", 0);
        }
    }
}
