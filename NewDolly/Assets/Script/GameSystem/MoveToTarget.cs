using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class MoveToTarget : MonoBehaviour, IPointerClickHandler
{
    public GameObject targetPosition;
    // Start is called before the first frame update
    public void OnPointerClick(PointerEventData eventData){
        
    }
    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(gameObject.transform.position,
        targetPosition.transform.position, 0.3f);
        gameManager.clear_c = true;
    }
}
