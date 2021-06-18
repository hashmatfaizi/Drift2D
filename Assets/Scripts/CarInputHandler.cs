using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CarInputHandler : MonoBehaviour
{
    public Button BtnUp;
    public Button BtnDown;
    public Button BtnLeft;
    public Button BtnRight;
    //Components
    TopDownCarController topDownCarController;
    public static Vector2 andoidAxis;

    public static bool UpIsPressed = false;
    public static bool DownIsPressed = false;
    public static bool RightIsPressed = false;
    public static bool LeftIsPressed = false;

    //Awake is called when the script instance is being loaded.
    void Awake()
    {
        topDownCarController = GetComponent<TopDownCarController>();
        andoidAxis = new Vector2();
    }

    // Update is called once per frame and is frame dependent
    void Update()
    {
        Vector2 inputVector = Vector2.zero;

        //Get input from Unity's input system.
        /*inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");*/

        inputVector.x = andoidAxis.x;
        inputVector.y = andoidAxis.y;

        //Send the input to the car controller.
        topDownCarController.SetInputVector(inputVector);
    }
}
