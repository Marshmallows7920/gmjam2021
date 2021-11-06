using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// This little hack script disables the mouse and locks it to the center of the screen. 
// Note: mouse clicks are still enabled. If you need them right off you have to remove all the mouse clicks from the buttons in InputManager, or do some sort of fancy extension of the Event system. 
// Note: your mouse will not show up at all while the scene is selected. Press ESC to step back to be able to edit with the Editor again
public class DisableMouse : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }
}
