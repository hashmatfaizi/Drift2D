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
    Vector2 andoidAxis;

    bool upPressed;
    bool downPressed;
    bool leftPressd;
    bool rightLeft;

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
        inputVector.x = Input.GetAxis("Horizontal");        
        inputVector.y = Input.GetAxis("Vertical");
        

        //Send the input to the car controller.
        topDownCarController.SetInputVector(inputVector);
    }
    
    public void BtnUpIsPreesd()
    {

    }

    public void BtnDownIsPreesd()
    {

    }

    public void BtnLeftIsPreesd()
    {

    }

    public void BtnRightIsPreesd()
    {

    }
}
