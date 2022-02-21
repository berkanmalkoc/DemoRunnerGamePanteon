using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public static CameraController Instance;
    public Transform playerPos;
    public bool running = true;

    public static object main { get; internal set; }

    void Start()
    {
        Instance = this;
    }

    void Update()
    {

        if (running)
        {
            CameraPoisitionControl(0, 0.7f, -1.5f);

            
        }
        else if (running == false)
        {
            transform.position = new Vector3(0, 3.86f, 38.59f);
            transform.rotation = Quaternion.Euler(90, 0, 0);
        }

    }

    public void CameraPoisitionControl(float q,float w ,float e)
    {
        transform.position = new Vector3(playerPos.position.x+q, playerPos.position.y + w, playerPos.position.z + e);

    }
}
