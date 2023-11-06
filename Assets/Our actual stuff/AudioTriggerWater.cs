using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTriggerWater : MonoBehaviour
{
    AudioSource audioData;
    bool isPlaying = false;
    public MeshCollider player;

    void Start()
    {
        audioData = GetComponent
            <AudioSource>();
        audioData.Play(0);
        audioData.Pause();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision player)
    {
        if(!isPlaying)
        {
            isPlaying = true;
            audioData.UnPause();
        }
    }
    private void OnCollisionExit(Collision player)
    {
        if(isPlaying)
        {
            isPlaying = false;
            audioData.Pause();
        }
    }
}
