using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Unpasue : MonoBehaviour
{

 PauseMenu pauseMenu;
public void PauseMenuOff()
    {
      SceneManager.UnloadSceneAsync("MenuPause", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
        pauseMenu.pasue = false;  
        Time.timeScale = 1;
    
    }
}
