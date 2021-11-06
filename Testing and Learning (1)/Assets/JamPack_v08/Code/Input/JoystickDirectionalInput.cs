using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum JoystickType{
    Left,
    Right
}

public class JoystickDirectionalInput : DirectionalInput {

    // Choose Joystick Number

    // which stick? 
    public JoystickType whichStick = JoystickType.Left;

    // Player ID
    // Update is called once per frame
    void Update(){
        if(whichStick == JoystickType.Left){
            inputVector.x = Input.GetAxis("Joystick1_Left_X");
            inputVector.y = Input.GetAxis("Joystick1_Left_Y");

        } else if (whichStick == JoystickType.Right){
            inputVector.x = Input.GetAxis("Joystick1_Right_X");
            inputVector.y = Input.GetAxis("Joystick1_Right_Y");
        }

    }
}
