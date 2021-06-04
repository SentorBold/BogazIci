using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Drag : MonoBehaviour, IPointerDownHandler, IBeginDragHandler , IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;

    private RectTransform rectTransform;

    private void Awake()
    {
        rectTransform = GetComponent<RectTransform>();
    }
    public void OnBeginDrag(PointerEventData evenData)
    {
        print("OnBeingDrag");
    }
    public void OnDrag(PointerEventData evenData)
    {
        print("OnDrag");
        rectTransform.anchoredPosition += evenData.delta / canvas.scaleFactor;
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
