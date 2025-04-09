using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public GameObject playerIRL;
    public GameObject playerIG;

    bool _ = true;

    private void Awake()
    {
        #region Singleton
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
        #endregion
    }

    // Start is called before the first frame update
    void Start()
    {
        playerIG.SetActive(false);
    }

       

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            //SwitchPlayer();
        }
    }



    /// <summary>
    /// Switch entre player IR et IG
    /// </summary>
    public void SwitchPlayer()
    {


        if (!_)
        {
            playerIG.SetActive(false);
            playerIRL.SetActive(true);
            Debug.Log("test !_");
        }

        if (_)
        {
            playerIG.SetActive(true);
            playerIRL.SetActive(false);
            Debug.Log("test _");
        }

        _ = !_;

    }

}
