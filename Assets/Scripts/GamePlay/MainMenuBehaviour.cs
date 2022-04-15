using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuBehaviour : MonoBehaviour
{
    //Loads the next scene
    public void LoadGame()
    {
        //Loads The next scene in the builds queue when the play button is hit
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    //Closes the application
    public void ExitApplication()
    {
        Debug.Log("Quit!");
        //Closes the application when the quit game button is hit
        Application.Quit();
    }
}
