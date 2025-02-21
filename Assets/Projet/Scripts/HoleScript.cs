using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public Player player;
    public GameObject changeLevel;
    public GameObject victory;

    public bool hole;

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
            if (player.actualCheckpoint >= 3)
            {
                if (player.actualCheckpoint == 6)
                {
                    Debug.Log("Victory"); victory.SetActive(true);
                }

                return;
            }
            StartCoroutine(ChangeLevel(2.35f));
        }
    }

    IEnumerator ChangeLevel(float t)
    {
        changeLevel.SetActive(true);
        yield return new WaitForSeconds(t);
        changeLevel.SetActive(false);
        player.transform.position = player.checkpoints[player.actualCheckpoint].position;
    }




}
