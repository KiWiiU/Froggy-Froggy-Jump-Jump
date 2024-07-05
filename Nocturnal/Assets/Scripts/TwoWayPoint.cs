using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TwoWayPoint : MonoBehaviour
{
    public GameObject lBeacon, rBeacon, target;
    public float speed;

    void Start()
    {
        target = lBeacon;
    }

    void Update()
    {
        Vector3 destination = target.transform.position;
        Vector3 newPos = Vector3.MoveTowards(transform.position, destination, speed * Time.deltaTime);
        transform.position = newPos;
        float distance = Vector3.Distance(transform.position, destination);
        if (distance < 0.5) 
        {
            if (target == lBeacon)
            {
                target = rBeacon;
            } else
            {
                target = lBeacon;
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "leftBeacon")
        {
            target = rBeacon;
        }

        if (other.name == "rightBeacon")
        {
            target = lBeacon;
        }
    }
}
