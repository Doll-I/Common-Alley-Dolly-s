using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dont : MonoBehaviour
{
    public static dont Instance;
    private void Awake(){
        if (Instance != null){
            Destroy(gameObject);
            return;
        }
        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
}
