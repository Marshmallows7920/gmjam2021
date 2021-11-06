using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

// This tells the UI which button should be selected first when the menu is enabled.
//      Advanced Description:
// This is a rabbit hole of a bug that seems really simple. 
// It has to do with a button being deselected, then selected in the same frame so the event system
// Doesn't know it was disables. The hack solution is to forcec the update by setting the select state to null
// https://answers.unity.com/questions/1159573/eventsystemsetselectedgameobject-doesnt-highlight.html
public class SetSelectedButton : MonoBehaviour
{
    public Button firstSelectedButton;

    // OnEnable is called whenever the UI is enabled. 
    //public void Start() {

    //    firstSelectedButton.Select(); // Select the button
    //    firstSelectedButton.OnSelect(null); // Reset the button listeners ?
    //}

    public void OnEnable() {

        firstSelectedButton.Select(); // Select the button
        firstSelectedButton.OnSelect(null); // Reset the button listeners ?
        // This is the same but going through the global event system to a GameObject
        //EventSystem.current.SetSelectedGameObject(firstSelectedButton.gameObject);
    }
}
