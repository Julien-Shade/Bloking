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
        dialogue.text = "Enfin à la maison...";
        yield return new WaitForSeconds(5f);
        dialogue.text = "Mais je peux même pas me reposer parce qu''il' a besoin de faire un FTUE...";
        yield return new WaitForSeconds(6f);
        dialogue.text = "Allons tester ce jeu : Low Game";
        yield return new WaitForSeconds(5f);
        dialogue.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
