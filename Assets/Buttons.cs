using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;


public class Buttons : MonoBehaviour
{
    private void Start()
    {
        SceneManager.UnloadSceneAsync("Main Menu");
    }
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadSceneAsync(1);
        SceneManager.LoadScene("Map");
         SceneManager.UnloadSceneAsync(0);
    }    
    public void quitGame()
    {
        Application.Quit();
    }
}
