using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class sliderTimer : MonoBehaviour
{
    public static sliderTimer Instance;
    Slider slTimer;
    float fSliderBarTime;
    float speed = 0.005f;

    // Start is called before the first frame update
    void Start()
    {
        slTimer = GetComponent<Slider>();
    }

    // Update is called once per frame
    void Update()
    {
        if (slTimer.value > 0.0f)
            slTimer.value -= Time.deltaTime * speed ;
        else
        {
            Debug.Log("Time is zero.");
        }
    }
    private void Awake(){
        if (Instance != null){
            Destroy(gameObject);
            return;
        }
        Instance = this;
    }
}