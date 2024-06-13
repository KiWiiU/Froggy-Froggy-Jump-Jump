using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseArea : MonoBehaviour
{
    public bool change;

    void OnTriggerEnter(Collider other)
    {
        UI.go = change;
    }
}
