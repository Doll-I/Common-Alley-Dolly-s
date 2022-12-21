using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bubbleAppear : MonoBehaviour
{
    public GameObject panel;

    bool questComplete = false; //퀘스트완료 변수

    // Start is called before the first frame update
    void Start()
    {
        panel.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            panel.SetActive(true);
            questComplete = true;
        }
    }
}
