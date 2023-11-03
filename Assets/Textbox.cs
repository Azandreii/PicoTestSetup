using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Textbox : MonoBehaviour
{
    // Start is called before the first frame update
    public Image textbox;
    public TMP_Text text;
    public GameObject player;

    public float distanceToTrigger = 10f;
    public string displayText = "empty";

    private float fadeTime = 3f;
    private bool faded = false;
/*    private Color fadeIn = new Color(1f, 1f, 1f, 1f);
    private Color fadeOut = new Color(1f, 1f, 1f, 0f);*/
    void Start()
    {
        text.gameObject.SetActive(false);
        textbox.gameObject.SetActive(false);
        text.text = displayText;
    }

    // Update is called once per frame
    void Update()
    {
        if (Vector3.Distance(this.transform.position, player.transform.position) < distanceToTrigger)
        {
            text.gameObject.SetActive(true);
            textbox.gameObject.SetActive(true);

            if (!faded)
            {
                Debug.Log("fading");
                textbox.canvasRenderer.SetAlpha(0);
                text.canvasRenderer.SetAlpha(0);
                textbox.CrossFadeAlpha(1f, fadeTime, false);
                text.CrossFadeAlpha(1f, fadeTime, false);
                faded = true;
            }
        }
        else if(text.gameObject.active) 
        {
            if (faded)
            {
                Debug.Log("fading");
                textbox.CrossFadeAlpha(0f, fadeTime, false);
                text.CrossFadeAlpha(0f, fadeTime, false);
                faded = false;
            }
        }
    }
}
