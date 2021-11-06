using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement; // Required to load a scene. 

public class MainMenu : MonoBehaviour {

    // Start is called before the first frame update
    public void LoadGameScene(int sceneIndex){
        // Loads the SECOND scene in the build index
        if( SceneManager.sceneCountInBuildSettings <= sceneIndex) {
            Debug.LogWarning("The Scene Selected is not found in the Build Settings Menu. You must set up multiple scenes in the Build Settings (File > Build Settings) to load them.");
            return;
        }

        SceneManager.LoadScene(sceneIndex);
    }

    public void QuitApplication(){
        Application.Quit();
    }

}
