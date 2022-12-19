using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class addCrown : MonoBehaviour
{
    public GameObject crown_l, crown;
    bool add = false;
    // Start is called before the first frame update
    void Start()
    {
        crown_l.SetActive(false);
        crown.SetActive(false);
        Invoke("goCrown", 2f);
    }

    void goCrown(){
        crown.SetActive(true);
        crown_l.SetActive(true);
        gameManager.clear_c = true;
        add = true;
    }
    // Update is called once per frame
    void Update(){
        if(add == true){
            crown.SetActive(true);
            crown_l.SetActive(true);
            gameManager.clear_c = true;
        }
    }
}
