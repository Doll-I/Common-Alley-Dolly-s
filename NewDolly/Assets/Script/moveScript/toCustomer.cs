using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class toCustomer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        gameManager.clear_c = true;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SceneChange()
    {
        if (gameManager.clear_c && gameManager.clear_l)
            SceneManager.LoadScene("customerSceneComplete");
        else
            SceneManager.LoadScene("customerScene");
    }
}