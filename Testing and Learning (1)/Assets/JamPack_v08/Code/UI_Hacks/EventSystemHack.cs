using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;


// This hack script goes on a UI menu and prevents two common issues with using a keyboard controlled UI menu:
// 1) Setting the first selected button
// prevents mouse clicks from disabling selection of a button by automatically turning them back on. 
// 2) Solution from 
// https://www.dylanwolf.com/2018/11/24/stupid-unity-ui-navigation-tricks/


public class EventSystemHack : MonoBehaviour
{

    // This deals with clicking outside of the UI losing highlighting
    private EventSystem currentEvents;
    private GameObject lastSelected;

    // Keeps a reference to the last selected element and reselects it if the event system loses reference(eg mouse clicks will do this)
    void Update()
    {
        // Initialize our local reference to the Event System and warn if it is missing from the Scene. 
        if(currentEvents == null){
            if(EventSystem.current != null){
                currentEvents = EventSystem.current;
            }else{
                Debug.LogWarning("No EventSystem found in this scene! Please add one to use Button input for the UI");
                return; // Bail out early
            }
        }

        // If the current event is selected but doesn't equal the currently stored selection, update the variable reference locally
        if( currentEvents.currentSelectedGameObject != null && currentEvents.currentSelectedGameObject != lastSelected){
            // Update the last selected
            lastSelected = currentEvents.currentSelectedGameObject;

            // In this case, the lastSelected variable is used to update the event system if its reference ever goes null
            // This happens when you click outside of the UI menu with a mouse and is a really annoying bug. 
        } else if (lastSelected != null && currentEvents.currentSelectedGameObject == null){
                currentEvents.SetSelectedGameObject(lastSelected);
        }
    }
}
