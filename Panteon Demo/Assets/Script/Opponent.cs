using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Opponent : MonoBehaviour
{

    public static Opponent Instance;
    public Transform waypoint;

    public bool play = false, move = false;
    
    public Animator animator;
    public bool run = true;
    

    float startX;
    float startZ;

    void Start()
    {
        Instance = this;

        

        startX = transform.position.x;
        startZ = transform.position.z;
      

    }


    private void Update()
    {
        transform.LookAt(waypoint.position);


        animator.SetBool("Run", true);
     

    }



    public void Restart()
    {
        transform.position = new Vector3(startX, 0, startZ);
        
        StartCoroutine(RunAgain());

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            
            
            
            Restart();
        }
    }

    IEnumerator RunAgain()
    {
        Follower follower = GetComponent<Follower>();
        yield return new WaitForSeconds(1.5f);
        
        follower.running = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "finishgame")
        {
           
            animator.SetBool("Run", false);
            



        }
    }
}
