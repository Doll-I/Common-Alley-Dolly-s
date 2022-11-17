using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canvasDontdestroy : MonoBehaviour
{
    public static canvasDontdestroy Instance;
    void Start()
    {
        
    }

    void Update()
    {
        
    }

    private void Awake(){
        if (Instance != null)  {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
