using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class TexteIteration : MonoBehaviour
{
    public TextMeshProUGUI clipText;

    public Player player;

    public string currentText;


    public string[] iteTab = new string[5];



    string ite1 = "Pas mal pour un d�butant, on comprend asser rapidement le concept de mettre la balle dans le trou pour reussir le d�fis.";
    string ite2 = "Un bon d�but d'it�ration, apr�s avoir appris au joueur � d�placer la balle dans le trou, il faut ensuite amener la balle jusqu'au trou � travers les obstacles.";
    string ite3 = "Le 3�me d�fis est interessant : il faut amemer 2 balle dans le trou au lieu d'un. Et il y a une nouvelle m�canique la fleche qui pousse. C'est tr�s bien comme it�ration.";
    string ite4 = "Mmm... Il a introduit la m�canique de la fleche cependant je pense qu'il faudrais le faire de maniere different meme si c'est amusant � voir.";
    string ite5 = "Il m'envoit le niveau 5 parcontre il est vide ? Il m'avait dit que c'�tait le dernier et qu'il avait pris en compte mon derniers feedback... Il s'est tromper de version ?";


    // Start is called before the first frame update
    void Start()
    {


        clipText.text = "";





        iteTab[0] = ite1;
        iteTab[1] = ite2;
        iteTab[2] = ite3;
        iteTab[3] = ite4;
        iteTab[4] = ite5;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            ChangeText();
        }


        if (player.actualCheckpoint == 1)
        {
            iteTab[0] = ite1;
        }
        if (player.actualCheckpoint == 2)
        {
            iteTab[1] = ite2;
        }
        if (player.actualCheckpoint == 3)
        {
            iteTab[2] = ite3;
        }
        if (player.actualCheckpoint == 4)
        {
            iteTab[3] = ite4;
            iteTab[4] = ite5;
        }
    }


    int i = 0; 
    public void ChangeText()
    {
        if (player.actualCheckpoint == 0) return;

        i++;

        if (player.actualCheckpoint == 4)
        {
            if (i >= 5)
            {
                i = 0;
            }
        }
        else
        {
            if (i >= player.actualCheckpoint)
            {
                i = 0;
            }
        }


        currentText = iteTab[i];
        clipText.text = currentText;

        
    }
}
