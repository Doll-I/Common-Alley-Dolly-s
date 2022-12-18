using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class custDontdestroy : MonoBehaviour
{
    public static custDontdestroy Instance;

    private void Awake(){
        if (Instance != null)  {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
