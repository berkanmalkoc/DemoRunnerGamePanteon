using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class PlayerController : MonoBehaviour
{
    public Transform waypoint;
    public float speed, yatayHiz;
    
  
    public bool play = false, move = false;
    private float posZ;
    private Animator animator;
    public GameObject endWall;
    Rigidbody rb;
    public GameObject button;

    float startX;
    float startZ;
    
    void Start()
    {
        Time.timeScale = 0;
        animator = GetComponent<Animator>();

        startX = transform.position.x;
        startZ = transform.position.z;
        rb = GetComponent<Rigidbody>();
    }
 

    private void Update()
    {
        posZ = gameObject.transform.position.z;

        
    }

    void FixedUpdate()
    {
        transform.LookAt(waypoint.position);
        float yatayHaraket = Input.GetAxis("Horizontal") * yatayHiz * Time.deltaTime;

        transform.Translate(yatayHaraket, 0, speed * Time.deltaTime);
        animator.SetBool("Run", true);
        move = true;
        if (Input.GetKey(KeyCode.UpArrow))
        {

          

        }
        if (Input.GetKeyUp(KeyCode.UpArrow))
        {
            animator.SetBool("Run", false);
        }
    }

    public void playButton()
    {
        play = true;
        Opponent.Instance.run = true;
        Follower.Instance.running = true;
        
        button.SetActive(false);
        Time.timeScale = 1;

    }
    
    public void Restart()
    {
        transform.position = new Vector3(startX, 0, startZ);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            
            Restart();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag== "finishgame")
        {
            endWall.SetActive(true);
            animator.SetBool("Run", false);
            CameraController.Instance.running = false;
            Time.timeScale = 0;
            Paintable paintable = endWall.GetComponent<Paintable>();
            paintable.paintOn = true;

            

        }

        if(other.gameObject.tag== "AddForce")
        {
            

        }
    }

}
