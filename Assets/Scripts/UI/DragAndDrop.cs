using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class DragAndDrop : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler
{
    private Image _image;
    private Rigidbody2D _rigidbody;

    private void Start()
    {
        _image = GetComponent<Image>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    public void OnBeginDrag(PointerEventData touch)
    {
        _image.color = new Color32(255, 255, 255, 160);
        _rigidbody.bodyType = RigidbodyType2D.Static;
    }

    public void OnDrag(PointerEventData touch)
    {
        _image.rectTransform.anchoredPosition += touch.delta;
    }

    public void OnEndDrag(PointerEventData touch)
    {
        _image.color = new Color(255, 255, 255, 255);
        _rigidbody.bodyType = RigidbodyType2D.Dynamic;
    }
}
