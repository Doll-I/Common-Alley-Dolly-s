using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class custDontdestroy : MonoBehaviour
{
    public static custDontdestroy Instance;
    private Scene scene;
    private void Awake(){
        if (Instance != null)  {
            Destroy(gameObject);
            return;
        }
        scene = SceneManager.GetActiveScene();
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if (scene.name != "customerScene") this.gameObject.SetActive(false);
    }
}
