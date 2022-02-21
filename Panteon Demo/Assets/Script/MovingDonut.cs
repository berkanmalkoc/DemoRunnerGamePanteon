using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingDonut : MonoBehaviour
{

    
    [SerializeField] float speed = 1f;
    bool onPlay = true;



    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(RestDonutMove());

    }

    // Update is called once per frame
    void Update()
    {

        
        transform.Translate(speed * Time.deltaTime, 0, 0);

    }

   

    public IEnumerator RestDonutMove()
    {
        while (onPlay)
        {
            speed = speed * -1;
            //transform.Translate(speed * Time.deltaTime, 0, 0);
            yield return new WaitForSeconds(1.5f);
            
        }
    }
}
