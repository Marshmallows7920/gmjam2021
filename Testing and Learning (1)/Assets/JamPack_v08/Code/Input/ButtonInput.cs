using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ButtonInput : MonoBehaviour
{
    // This is the name of the input command
    public string buttonString = "Jump";

    [Header("*** Input Variables ***")]
    public bool buttonDown = false;
    public bool buttonDownThisFrame = false;
    public bool buttonUpThisFrame = false;

    [Header("*** Events that were called ***")]
    public UnityEvent buttonDownEvent;
    public UnityEvent buttonUpEvent;

    public bool DEBUG_MODE = false;

    public void Update() {
        
        // Gets the Jump Button from the input system
        buttonDown = Input.GetButton(buttonString);
        buttonDownThisFrame = Input.GetButtonDown(buttonString);
        buttonUpThisFrame = Input.GetButtonUp(buttonString);

        // On the frame where the button is pressed, fire this message. 
        if ( buttonDownThisFrame){
            buttonDownEvent.Invoke();
            if(DEBUG_MODE){ Debug.Log("ButtonDown " + gameObject.name + " BUtton:" + buttonString); }
        }

        // On the frame where the button is released, fire this message. 
        if (buttonUpThisFrame) {
            buttonUpEvent.Invoke();
          
            if (DEBUG_MODE) {Debug.Log("Button UP " + gameObject.name + " BUtton:" + buttonString);}
        }
    }

}
