using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DirectionalInput : MonoBehaviour {    
    
    // set up a vector 2 to hold the input from the player
    public Vector2 inputVector = Vector2.zero;

    // Update is called once per frame
    void Update()
    {
        // Gets the input values from the arrow keys (by default)
        inputVector.x = Input.GetAxis("Horizontal");
        inputVector.y = Input.GetAxis("Vertical");

        // this will return us a value for x and y between -1 and 1
        // you can also do them seperately and handle the x axis and y axis each on thier own float    
    }
}
