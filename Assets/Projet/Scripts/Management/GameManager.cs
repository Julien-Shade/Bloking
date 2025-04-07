using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{

    public static GameManager Instance;

    public GameObject player;

    public GameObject[] objectScene;

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

        SceneManager.LoadSceneAsync(1, LoadSceneMode.Additive);
        SceneManager.SetActiveScene(SceneManager.GetSceneByBuildIndex(1));


        //desactiver le Player (ingame ingame)
        Scene scene = SceneManager.GetSceneByBuildIndex(1);


        //player.SetActive(false);

        objectScene = scene.GetRootGameObjects();

        

            //player.SetActive(false);


        AnalyserScene(scene);


            //SceneManager.MergeScenes(SceneManager.GetSceneByBuildIndex(1),SceneManager.GetActiveScene());
    }

       




    



    void AnalyserScene(Scene scene)
    {
        // Obtenir tous les objets racine
        GameObject[] rootObjects = scene.GetRootGameObjects();

        foreach (GameObject rootObject in rootObjects)
        {
            Debug.Log($"Objet racine trouvé : {rootObject.name}");

            // Parcourir tous les enfants récursivement
            foreach (Transform child in rootObject.GetComponentsInChildren<Transform>())
            {
                Debug.Log($"  -> Enfant : {child.name}");
            }
        }
    }


    // Update is called once per frame
    void Update()
    {

    }

}
