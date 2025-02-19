using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GetOut : MonoBehaviour
{
    [SerializeField]
    private float forceX;
    [SerializeField]
    private float forceY;
    [SerializeField]
    private float forceZ;

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            rb.AddForce(new(forceX, forceY, forceZ));
        }
    }
}
