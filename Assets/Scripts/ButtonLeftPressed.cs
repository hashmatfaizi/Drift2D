using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonLeftPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
            if (!CarInputHandler.RightIsPressed)
            {
                CarInputHandler.andoidAxis.x = -1;
                CarInputHandler.LeftIsPressed = true;
            }
            else
            {
                CarInputHandler.andoidAxis.x = 0;
                CarInputHandler.LeftIsPressed = false;
            }
        }
        else
        {
            if (!CarInputHandler.RightIsPressed)
            {
                CarInputHandler.andoidAxis.x = 0;
                CarInputHandler.LeftIsPressed = false;
            }
        }
    }
    private void Update()
    {
        ButtoiIsPressed();
    }
}
