using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public Player player;
    public GameObject changeLevel;
    public GameObject victory;
    public TexteIteration texteIteration;

    public bool hole;

    bool _oneTime = false;

    private void Start()
    {
        changeLevel.SetActive(false);
        victory.SetActive(false);
    }





    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            hole = true;
            Debug.Log("Hole in One !!!");



            player.actualCheckpoint++;


            if (player.actualCheckpoint == 1)
            {
                StartCoroutine(ChangeLevel(2.35f));
            }

            if (player.actualCheckpoint == 2)
            {
                StartCoroutine(ChangeLevel(2.35f));
            }

            if (player.actualCheckpoint == 3)
            {
                OneTime();
            }
            if (player.actualCheckpoint == 3)
            {
                StartCoroutine(ChangeLevel(2.35f));
            }

            if (player.actualCheckpoint == 4)
            {
                StartCoroutine(ChangeLevel(2.35f));
            }


        }
    }


    private void OneTime()
    {
        if (_oneTime) return;
        player.actualCheckpoint--;
        _oneTime = true;
    }

    IEnumerator ChangeLevel(float t)
    {
        changeLevel.SetActive(true);

        yield return new WaitForSeconds(t);
        player.transform.position = player.checkpoints[player.actualCheckpoint].position;
        changeLevel.SetActive(false);
        GameManager.Instance.SwitchPlayer();
        texteIteration.ChangeText();




    }




}
