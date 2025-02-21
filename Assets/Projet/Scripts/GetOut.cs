using System.Collections;
using System.Collections.Generic;
//using Unity.VisualScripting;
using UnityEngine;

public class GetOut : MonoBehaviour
{
    [SerializeField]
    private float forceX;
    [SerializeField]
    private float forceY;
    [SerializeField]
    private float forceZ;

    private Vector3 direction;

    [SerializeField]
    private float forceMagnitude;

    private void Start()
    {
        
        Debug.Log("direcction = " + direction);
    }

    private void Update()
    {
        direction = transform.forward;
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            Rigidbody rb = other.GetComponent<Rigidbody>();
            //rb.AddForce(new(forceX, forceY, forceZ));
            rb.AddForce(direction * forceMagnitude);
        }
    }

  
}
