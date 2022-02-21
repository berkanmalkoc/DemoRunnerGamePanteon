using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticObstacle : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Girl")
        {
            Follower follower = collision.gameObject.GetComponent<Follower>();
            follower.running = false;
        }
    }
}
