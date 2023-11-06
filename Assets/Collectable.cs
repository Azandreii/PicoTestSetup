using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using TMPro;
using Unity.XR.CoreUtils;
using UnityEngine;
using UnityEngine.Assertions.Must;
using UnityEngine.UI;

public class Collectable : MonoBehaviour
{

    private Vector3 startingPosition;
    public Player player;

    public TMP_Text text;
    public Image image;
    public Canvas canvas;


    bool timeStarted = false;
    // Start is called before the first frame update
    // Update is called once per frame


    private void Awake()
    {
        startingPosition = gameObject.transform.position;
    }
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, startingPosition) > 1.5f)
        {
            //TODO: Particles
           
            text.text = string.Format("Memories found: {0}/{1}", player.collectablesFound, player.maxCollectables);
          
            if (!timeStarted)
            {
                canvas.transform.position = startingPosition
                + new Vector3(0f, 2.5f, 0f);
                player.collectablesFound += 1;
              /*  text.canvasRenderer.SetAlpha(1f);
                image.canvasRenderer.SetAlpha(1f);*/
                Debug.Log("Should show alpha");
                timeStarted = true;
                StartCoroutine(fadeOut(3f));
                
            }
        }
    }
    IEnumerator fadeOut(float fadeOutTime)

    {
        yield return new WaitForSeconds(3f);
        text.CrossFadeAlpha(0f, fadeOutTime, false);
        image.CrossFadeAlpha(0f, fadeOutTime, false);
        //gameObject.SetActive(false);
    }
}
