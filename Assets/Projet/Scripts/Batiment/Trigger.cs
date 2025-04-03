using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public bool isIn;

    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //afficher écran ?
            isIn = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //désafficher "écran"
            isIn = false;
        }

    }
}
