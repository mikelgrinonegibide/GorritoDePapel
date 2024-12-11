using System.Collections;
using System.Collections.Generic;
using Unity.Loading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseMenu : MonoBehaviour
{
    
    public bool pasue = false;

public void Update()
{
if(Input.GetKeyDown(KeyCode.Escape)&& pasue==false)
{
    
   SceneManager.LoadSceneAsync("MenuPause",LoadSceneMode.Additive);
   Time.timeScale = 0;
   pasue= true;
}
}

}
