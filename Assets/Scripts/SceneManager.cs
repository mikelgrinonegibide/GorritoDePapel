using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

using UnityEngine.SceneManagement;
using UnityEngine.UI;
using UnityEngine.UIElements;



public class SceneChanger : MonoBehaviour
{
    



#region script botones

//funciones las cuales permiten el cambio de escena 


public void TotheBedroom()
    {
        SceneManager.LoadSceneAsync( "Dormitorio", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Salon", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }

public void TotheKitchen()
    {
        SceneManager.LoadSceneAsync( "Cocina", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Salon", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
public void TotheLivingRoomFromKitchen()
    {
        SceneManager.LoadSceneAsync( "Salon", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Cocina", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }

public void TotheDesvan()
    {
        SceneManager.LoadSceneAsync( "Desvan", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Dormitorio", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }

public void TotheBedroomFromDesvan()
    {
        SceneManager.LoadSceneAsync( "Dormitorio", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Desvan", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
public void TotheBathroom()
    {
        SceneManager.LoadSceneAsync( "Baño", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Salon", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }

public void TotheLivinRoomFromBedroom()
    {
        SceneManager.LoadSceneAsync( "Salon", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Dormitorio", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
public void TotheLivinRoomFromBathroom()
    {
        SceneManager.LoadSceneAsync( "Salon", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Baño", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
public void TotheGraveYard()
    {
        SceneManager.LoadSceneAsync( "Cementerio", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Plaza", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
public void TothePlazaFromGraveYard()
    {
        SceneManager.LoadSceneAsync( "Plaza", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Cementerio", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
public void TothePlazaFromLivingRoomm()
    {
        SceneManager.LoadSceneAsync( "Plaza", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Salon", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }
public void TotheLivingRoomFroomPlaza()
    {
        SceneManager.LoadSceneAsync( "Salon", LoadSceneMode.Single);
        SceneManager.UnloadSceneAsync("Plaza", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }

    public void StartGame()
    {
    SceneManager.LoadSceneAsync( "Salon", LoadSceneMode.Single);
    SceneManager.UnloadSceneAsync("MainScreen", UnloadSceneOptions.UnloadAllEmbeddedSceneObjects);
    }


#endregion
}
