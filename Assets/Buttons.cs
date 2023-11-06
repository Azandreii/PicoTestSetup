using System.Collections;
using System.Collections.Generic;
using UnityEditor.SceneManagement;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private void Start()
    {
        SceneManager.UnloadSceneAsync(1);
    }
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadSceneAsync(1);
        EditorSceneManager.OpenScene("Map");
         SceneManager.UnloadSceneAsync(0);
    }    
    public void quitGame()
    {
        Application.Quit();
    }
}
