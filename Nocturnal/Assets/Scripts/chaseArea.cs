using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chaseArea : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            UI.go = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            UI.go = false;
        }
    }
}
