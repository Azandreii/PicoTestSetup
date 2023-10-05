using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Nearsight_Orb : MonoBehaviour
{
    public float loadRange = 20f;
    private void Start()
    {
        Camera camera = GetComponent<Camera>();

        camera.farClipPlane = loadRange;
            
    }
    
    // Start is called before the first frame update

    // Update is called once per frame
    void Update()
    {
     
    }
}
