using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HorizontalObstacle : MonoBehaviour
{
    
    [SerializeField] float range=0.68f;
    private float speed;
    public bool active = true;

    
    
    // Start is called before the first frame update
    void Start()
    {
        speed = 0.5f;
        
    }

    // Update is called once per frame
    void Update()
    {
      
        
      Move();
        

    }

    private void Move()
    {
        
        if (transform.position.x >= range)
        {
            speed = -0.5f;
            
        }
        if (transform.position.x <= -range)
        {
            speed = 0.5f;
            
        }
        transform.Translate(1 * speed * Time.deltaTime, 0, 0);
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Girl")
        {
            Follower follower = collision.gameObject.GetComponent<Follower>();
            follower.running = false;
        }
    }
}
