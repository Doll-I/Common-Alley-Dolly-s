using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cutScene3 : MonoBehaviour
{
    public GameObject cut3_0, cut3_1, cut3_2, cut3_3, cut3_4, cut3_51, cut3_52, cut3_53, cut3_54, cut3_6, cut3_511;

    private void Start(){
        Destroy(cut3_0, 1);
        Destroy(cut3_1, 2);
        Destroy(cut3_2, 3);
        Destroy(cut3_3, 4);
        Destroy(cut3_4, 5);
        Destroy(cut3_51, 6);
        Destroy(cut3_511, 6);
        Destroy(cut3_52, 6);
        Destroy(cut3_53, 6);
        Destroy(cut3_54, 6);
        Destroy(cut3_6, 7);
    }
}
