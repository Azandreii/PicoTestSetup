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
    // Start is called before the first frame update
    // Update is called once per frame


    private void Awake()
    {
        startingPosition = gameObject.transform.position;
    }
    void Update()
    {
        if (Vector3.Distance(gameObject.transform.position, startingPosition) > 3f)
        {
            //TODO: Particles
            player.collectablesFound += 1;
            text.text = string.Format("Memories found: {0}/{1}", player.collectablesFound, player.maxCollectables);
            text.canvasRenderer.SetAlpha(1f);
            image.canvasRenderer.SetAlpha(1f);
            gameObject.SetActive(false);
            StartCoroutine(fadeOut(3f));
        }
    }
    IEnumerator fadeOut(float fadeOutTime)

    {
        yield return new WaitForSeconds(3f);
        text.CrossFadeAlpha(0f, fadeOutTime, false);
        image.CrossFadeAlpha(0f, fadeOutTime, false);
    }
}
