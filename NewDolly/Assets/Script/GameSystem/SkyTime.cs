using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyTime : MonoBehaviour
{
    public static SkyTime Instance;

    public float upMax = 8.5f;
    public float currentPosition;
    float speed = 0.17f;

    void Start()
    {
        currentPosition = transform.position.y;
    }

    void Update()
    {
        currentPosition += Time.deltaTime * speed;
        if (currentPosition >= upMax)
        {
            currentPosition = upMax;
        }

        transform.position = new Vector3(0, currentPosition, 0);
    }
}