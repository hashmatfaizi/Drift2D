using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonRightPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
            if (!CarInputHandler.LeftIsPressed)
            {
                CarInputHandler.andoidAxis.x = 1;
                CarInputHandler.RightIsPressed = true;
            }
            else
            {
                CarInputHandler.andoidAxis.x = 0;
                CarInputHandler.RightIsPressed = false;
            }
        }
        else
        {
            if (!CarInputHandler.LeftIsPressed)
            {
                CarInputHandler.andoidAxis.x = 0;
                CarInputHandler.RightIsPressed = false;
            }
        }
    }
    private void Update()
    {
        ButtoiIsPressed();
    }
}
