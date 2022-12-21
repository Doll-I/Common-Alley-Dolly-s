using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class SoundManager : MonoBehaviour
{

    public AudioSource audioSource;
    public AudioClip audioSign;
    public AudioClip audioIntro;
    public AudioClip audioButton;
    public static SoundManager instance;
    public Scene scene;
    public TextMeshProUGUI coin;

    void Awake(){
        if (SoundManager.instance == null){
            SoundManager.instance = this;
        }
        if (SceneManager.GetActiveScene().name == "customerScene"){
            Destroy(gameObject);
        }
        if (SceneManager.GetActiveScene().name == "customerSceneComplete"){
            coin.text = "500";
        }
    }

    void Update(){
        scene = SceneManager.GetActiveScene();
    }
    
    public void PlaySign(){
        audioSource.PlayOneShot(audioSign);
    }

    public void PlayIntro(){
        audioSource.PlayOneShot(audioIntro);
    }

    public void PlayButton(){
        audioSource.PlayOneShot(audioButton);
    }
}
