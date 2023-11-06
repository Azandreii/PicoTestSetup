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
        /*        if (!characterController.velocity.Equals(new Vector3(0f, 0f, 0f)))
                {
                    if (!isPlaying)
                    {
                        audioData.UnPause();
                        isPlaying = true;
                    }
                }
                else
                {
                    if (isPlaying)
                    {
                        audioData.Pause();
                        isPlaying = false;
                    }
                }

            }*/
    }
}
