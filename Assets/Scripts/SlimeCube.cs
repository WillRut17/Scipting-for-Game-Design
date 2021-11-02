using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeCube : MonoBehaviour
{
    public GameObject deathParticles;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            Vector3 otherPosition = other.transform.position;

            Instantiate(deathParticles, otherPosition, Quaternion.identity);

            Destroy(other.gameObject);
        }
    }
}