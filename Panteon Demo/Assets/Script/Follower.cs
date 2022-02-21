using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PathCreation;

public class Follower : MonoBehaviour
{
    public static Follower Instance;
    public PathCreator pathCreator;
    public float speed = 5;
    float distanceTravelled;
    public bool running = false;
    

    float startX;
    float startZ;
    private void Start()
    {
        Instance = this;
        startX = gameObject.transform.position.x;
        startZ = gameObject.transform.position.z;
    }
    // Update is called once per frame
    void Update()
    {
        if (running==true)
        {
            distanceTravelled += speed * Time.deltaTime;
            transform.position = pathCreator.path.GetPointAtDistance(distanceTravelled);
        }

        if (running == false)
        {
            distanceTravelled = 0;
            transform.position= new Vector3(startX, 0.014f, startZ);
        }
    }

 
}
