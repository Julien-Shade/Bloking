using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HoleScript : MonoBehaviour
{
    public Player player;


    public bool hole; 

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Ball"))
        {
            hole = true;
            Debug.Log("Hole in One !!!");
            player.actualCheckpoint++;
            if (player.actualCheckpoint >= 3)
            {
                if (player.actualCheckpoint == 5)
                {
                    Debug.Log("Victory"); 
                }

                return;
            }
            player.transform.position = player.checkpoints[player.actualCheckpoint].position;
        }
    }
}
