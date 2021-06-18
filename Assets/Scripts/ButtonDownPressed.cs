using UnityEngine;
using UnityEngine.EventSystems;

public class ButtonDownPressed : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
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
            if (!CarInputHandler.UpIsPressed)
            {
                CarInputHandler.andoidAxis.y = -1;
                CarInputHandler.DownIsPressed = true;
            }
            else
            {
                CarInputHandler.andoidAxis.y = 0;
                CarInputHandler.DownIsPressed = false;
            }
        }
        else
        {
            if (!CarInputHandler.UpIsPressed)
            {
                CarInputHandler.andoidAxis.y = 0;
                CarInputHandler.DownIsPressed = false;
            }
        }
    }
    private void Update()
    {
        ButtoiIsPressed();
    }
}
