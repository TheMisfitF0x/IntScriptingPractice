using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System.Runtime.InteropServices;

public class DragDrop : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    private RectTransform rectTransform;
    // Start is called before the first frame update
    void Start()
    {
        this.rectTransform = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnPointerDown(PointerEventData eData)
    {

    }
    public void OnBeginDrag(PointerEventData eData)
    {

    }
    public void OnDrag(PointerEventData eData)
    {
        this.rectTransform.anchoredPosition += eData.delta;
    }

    public void OnEndDrag(PointerEventData eData)
    {
        this.SendMessage("OnPlay", SendMessageOptions.DontRequireReceiver);
    }    
}
