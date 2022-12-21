using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundDontdestroy : MonoBehaviour
{
     public static soundDontdestroy Instance;
    private void Awake(){
        if (Instance != null)  {
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
