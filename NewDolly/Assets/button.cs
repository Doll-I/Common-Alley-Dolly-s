using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public static button Instance;
    private void Awake(){
        if (Instance != null){
            return;
        }
        else {
            Instance = this;
        DontDestroyOnLoad(gameObject);
        }
    }
    public AudioSource audioSource;
    public AudioClip audioButton; 
    // Start is called before the first frame update
    
    public void PlayButton(){
        audioSource.PlayOneShot(audioButton);
    }
}
