using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoveToTarget : MonoBehaviour
{
    public GameObject targetPosition;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(gameObject.transform.position,
        targetPosition.transform.position, 0.3f);
        gameManager.clear_c = true;
    }
}
