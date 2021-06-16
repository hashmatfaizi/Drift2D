using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoadCollisionController : MonoBehaviour
{
    public Collider2D Car;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision == Car)
        {
            GameController.CarOnTheRoad = true;            
        }
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision == Car)
        {            
            GameController.CarOnTheRoad = false;
        }
    }
}
