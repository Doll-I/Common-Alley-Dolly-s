using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutScene2 : MonoBehaviour
{
    public GameObject cut2_0, cut2_1, cut2_2, cut2_3, cut2_4, cut2_5, cut2_6;

    private void Start(){
        Destroy(cut2_0, 0.5f);
        Destroy(cut2_1, 1);
        Destroy(cut2_2, 2);
        Destroy(cut2_3, 3);
        Destroy(cut2_4, 4);
        Destroy(cut2_5, 5);
        Destroy(cut2_6, 6);
    }
}
