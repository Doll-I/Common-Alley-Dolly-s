using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class canvasDontdestroy : MonoBehaviour
{
    public static canvasDontdestroy Instance;
    private Scene scene;

    private void Awake(){
        if (Instance != null)  {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
        
    }
    private void Update()
    {
        scene = SceneManager.GetActiveScene();
        //if (scene.name == "customerSceneComplete")
        //    Destroy(gameObject);
    }
}
