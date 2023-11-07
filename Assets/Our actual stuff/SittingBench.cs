using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Content.Interaction;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.XR.Interaction.Toolkit.AffordanceSystem.Receiver.Primitives;

public class SittingBench : MonoBehaviour
{
    public GameObject player;
    public GameObject leftController;
    public GameObject grab;
    public GameObject backoutbutton;


    Vector3 SittingSpot;

    bool meditate;

    void Start()
    {

        SittingSpot = grab.transform.position;

    }


    void Update()
    {
      if (grab.GetComponent<XRGrabInteractable>().isSelected == true)
        {
            meditate = true;
            
        }

      if(meditate == true)
        {
            
            player.transform.position = SittingSpot;
            leftController.SetActive(false);

            backoutbutton.SetActive(true);



        }

    }


    public void BackOutButton()
    {
        leftController.SetActive(true);
        backoutbutton.SetActive(false);
        meditate = false;
        
    }
    

}
