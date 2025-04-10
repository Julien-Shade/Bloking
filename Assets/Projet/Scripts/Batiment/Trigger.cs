using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{

    public bool isIn;

    public GameObject canvaPC;
    public GameObject canvaPC_1;





    private void Start()
    {
        canvaPC.SetActive(false);
        canvaPC_1.SetActive(false);
    }



    private void Update()
    {
        if (canvaPC.activeSelf)
        {
            if (Input.GetKeyDown(KeyCode.E))
            {
                GameManager.Instance.SwitchPlayer();
                canvaPC.SetActive(false);
                canvaPC_1.SetActive(false);
            }
        }
    }



    private void OnTriggerEnter(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //afficher écran ?
            canvaPC.SetActive(true);
            canvaPC_1.SetActive(true);
            isIn = true;
        }
    }

    
    private void OnTriggerExit(Collider other)
    {

        if (other.CompareTag("Player"))
        {
            //désafficher "écran"
            canvaPC.SetActive(false);
            canvaPC_1.SetActive(false);
            isIn = false;
        }

    }
}
