using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Dialogue : MonoBehaviour
{
    public TextMeshProUGUI dialogue;




    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(DebutDialogue());
    }

    IEnumerator DebutDialogue()
    {
        dialogue.text = "*Sigh* ...";
        yield return new WaitForSeconds(3f);
        dialogue.text = "Je dois encore tester le jeu de ce developpeur...";
        yield return new WaitForSeconds(5f);
        dialogue.text = "----- vraiment ce mec je l'aime pas mais bon... au moins je suis payer même si c'est peu.";
        yield return new WaitForSeconds(6f);
        dialogue.text = "Bon aller ! Allons le tester ce jeu : Low Game";
        yield return new WaitForSeconds(5f);
        dialogue.text = "";


    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
