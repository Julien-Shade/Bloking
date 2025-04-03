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
            //afficher �cran ?
            isIn = true;
        }


    }

    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //d�safficher "�cran"
            isIn = false;
        }

    }
}
