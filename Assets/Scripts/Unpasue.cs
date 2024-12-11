using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TestTools;

public class Unpasue : MonoBehaviour
{

 PauseMenu pauseMenu;
public void PauseMenuOff()
    {
      SceneManager.UnloadSceneAsync("MenuPause", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
        pauseMenu.pasue = false;  
        Time.timeScale = 1;
    
    }

public void ExitGasme()
{

    #if UNITY_EDITOR
        // Application.Quit() does not work in the editor so
        // UnityEditor.EditorApplication.isPlaying need to be set to false to end the game
        UnityEditor.EditorApplication.isPlaying = false;
    #else
        Application.Quit();
    #endif
}
}
