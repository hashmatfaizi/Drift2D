using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonUpPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    private bool isDown;

    public void OnPointerDown(PointerEventData eventData)
    {
        this.isDown = true;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        this.isDown = false;
    }

    public void ButtoiIsPressed()
    {
        if (isDown)
        {
            if (!CarInputHandler.DownIsPressed)
            {
                CarInputHandler.andoidAxis.y = 1;
                CarInputHandler.UpIsPressed = true;
            }
            else
            {
                CarInputHandler.andoidAxis.y = 0;
                CarInputHandler.UpIsPressed = false;
            }
        }
        else
        {
            if (!CarInputHandler.DownIsPressed)
            {
                CarInputHandler.andoidAxis.y = 0;
                CarInputHandler.UpIsPressed = false;
            }
        }
    }
    private void Update()
    {
        ButtoiIsPressed();
    }
}
