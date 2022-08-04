using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] cameras;
    public int CameraState = 0;


    void Start()
    { 


        CameraState = 0;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F1))
        {
            /*cameras[0].SetActive(true);
            cameras[1].SetActive(false);*/
            if (CameraState == 0)
            {
                cameras[0].SetActive(true);
                cameras[1].SetActive(false);
                CameraState = 1;
            } else
            {
                cameras[0].SetActive(false);
                cameras[1].SetActive(true);
                CameraState = 0;
            }

            /*if (cameras[1] == true)
            {
                cameras[0].SetActive(true);
                cameras[1].SetActive(false);

            }*/

        }





       /* if(Input.GetKeyDown(KeyCode.F2))
        {
            cameras[0].SetActive(false);
            cameras[1].SetActive(true);
            //cameras[2].SetActive(false);
        }*/
    }
}
