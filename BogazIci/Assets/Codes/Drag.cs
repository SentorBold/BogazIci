using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler , IEndDragHandler, IDragHandler
{
    

    private Transform transform;

    private void Awake()
    {
        transform = GetComponent<Transform>();
    }
    public void OnBeginDrag(PointerEventData evenData)
    {
        print("OnBeingDrag");
    }
    public void OnDrag(PointerEventData evenData)
    {
        print("OnDrag");
        transform.position += (Vector3)evenData.delta; // canvas.scaleFactor;
    }
    public void OnEndDrag(PointerEventData evenData)
    {
        print("OnEndDrag");
    }
    public void OnPointerDown(PointerEventData evenData)
    {
        print("x");
    }
  
  
}
