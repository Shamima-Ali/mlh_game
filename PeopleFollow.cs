using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// some code from Blackthornprod

public class PeopleFollow : MonoBehaviour
{
    public float speed;
    private Transform target;
    public float chaseRange;
    // Start is called before the first frame update

    void Start()
    {
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }




    // Update is called once per frame
    void FixedUpdate()
    {
        float distanceToTarget = Vector3.Distance(transform.position, target.position);
        if(distanceToTarget < chaseRange)
        {
            if (target.position != null)
            {
                transform.position = Vector2.MoveTowards(transform.position, target.position, speed*Time.deltaTime);
            }
        }
        

    }
}

   

