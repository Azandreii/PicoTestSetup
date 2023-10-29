using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    private void Start()
    {
        SceneManager.UnloadSceneAsync(2);
    }
    // Start is called before the first frame update
    public void playGame()
    {
        SceneManager.LoadSceneAsync(2);
        SceneManager.UnloadSceneAsync(1);
    }    
}
