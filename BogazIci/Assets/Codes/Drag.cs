using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour // IPointerDownHandler, IBeginDragHandler , IEndDragHandler, IDragHandler
{
    Vector3 previouspos;
    public float sens;

    /* private Transform transform;

     private void Awake()
     {
         transform = GetComponent<Transform>();
     }
     public void OnBeginDrag(PointerEventData evenData)
     {
         print("Worked");
     }
     public void OnDrag(PointerEventData evenData)
     {
         print("Worked");
         transform.position += (Vector3)evenData.delta; // canvas.scaleFactor;
     }
     public void OnEndDrag(PointerEventData evenData)
     {
         print("");
     }
     public void OnPointerDown(PointerEventData evenData)
     {
         print("x");
     }  */
    private void OnMouseDrag()
    {
        var current = Input.mousePosition;
        var delta = current - previouspos;
        transform.position += delta * sens;

        previouspos = current;
    }
    private void OnMouseDown()
    {
        previouspos = Input.mousePosition;
    }

    private void OnMouseEnter()
    {
        
    }
}
