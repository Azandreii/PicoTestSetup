using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class AudioWind : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource audioData;
    bool isPlaying = false;
    public Transform player;
    CharacterController characterController;

    void Start()
    {
        audioData = GetComponent
            <AudioSource>();
        audioData.Play(0);
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine("WindCooldown");
    }
               
    

    IEnumerator WindCooldown()
    {
        if (!isPlaying)
        {
            audioData.UnPause();
            isPlaying = true;
        }
           

        yield return new WaitForSeconds(Random.Range(10f, 15f));

        if (isPlaying)
        {
            audioData.Pause();
            isPlaying = false;
        }

        yield return new WaitForSeconds(Random.Range(10f, 15f));


    }
}
