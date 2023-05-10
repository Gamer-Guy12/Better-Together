using UnityEngine;

public class VCam : MonoBehaviour
{

    [SerializeField] bool isOn;
    [SerializeField] int camId;

    void Start()
    {

        if (!CameraSwapper.instance.oneIsTaken)
        {

            camId = 0;
            CameraSwapper.instance.oneIsTaken = true;

        }
        else
        {

            camId = 1;

        }
        
    }

    void Update()
    {

        if (camId == 0 && CameraSwapper.instance.onCam)
        {

            isOn = true;

        }
        else if (camId == 1 && !CameraSwapper.instance.onCam)
        {

            isOn = true;

        }
        else
        {

            isOn = false;

        }

        if (isOn)
        {

            GetComponent<Camera>().enabled = true;

        }
        else
        {

            GetComponent<Camera>().enabled = false;

        }

    }

}
