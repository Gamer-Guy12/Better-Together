using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraSwapper : MonoBehaviour
{

    public static CameraSwapper instance;
    public bool onCam;
    public bool oneIsTaken;
    public float timer = 5;

    void Awake()
    {

        instance = this;
        
    }

    void Update()
    {

        if (timer <= 0 && onCam)
        {

            onCam = false;
            timer = 5;

        }
        else if (timer <= 0 && !onCam)
        {

            onCam = true;
            timer = 5;

        }

        timer -= Time.deltaTime;

    }

}
