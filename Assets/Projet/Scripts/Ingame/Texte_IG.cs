using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Texte_IG : MonoBehaviour
{

    public GameObject texte_Esc;


    // Start is called before the first frame update
    void Start()
    {
        texte_Esc.SetActive(false);
    }


    private void OnEnable()
    {
        texte_Esc.SetActive(true);
    }

    private void OnDisable()
    {
        texte_Esc.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
