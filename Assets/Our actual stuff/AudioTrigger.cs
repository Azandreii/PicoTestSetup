using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioTrigger : MonoBehaviour
{
    // Start is called before the first frame update

    AudioSource audioData;
    bool isPlaying = false;
    public Transform player;

    void Start()
    {
        audioData = GetComponent
            <AudioSource>();
        audioData.Play(0);
        audioData.Pause();
        Debug.Log("This worked we're so back");
    }

    // Update is called once per frame
    void Update()
    {
        if(Vector3.Distance(this.transform.position,player.transform.position) < 1f)
        {
            if(!isPlaying)
            {
                audioData.UnPause();
                isPlaying = true;
            }
        }
        else
        {
            if(isPlaying)
            {
                audioData.Pause();
                isPlaying = false;
            }
        } 
            
    }
}
