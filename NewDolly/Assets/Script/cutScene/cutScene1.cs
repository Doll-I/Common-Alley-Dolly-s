using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutScene1 : MonoBehaviour
{
    public GameObject cut1_0, cut1_1, cut1_2, cut1_3, cut1_4;

    private void Start(){
        Destroy(cut1_0, 1);
        Destroy(cut1_1, 2);
        Destroy(cut1_2, 3);
        Destroy(cut1_3, 4);
        Destroy(cut1_4, 5);
    }
    
}

