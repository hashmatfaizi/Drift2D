using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public abstract class ButtonPressed : MonoBehaviour
{
    protected bool isDown;

    public void OnPointerDown(PointerEventData eventData)
    {
        this.isDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.isDown = false;
    }

    void Update()
    {
        ButtoiIsPressed();
    }

    public abstract void ButtoiIsPressed();
}
