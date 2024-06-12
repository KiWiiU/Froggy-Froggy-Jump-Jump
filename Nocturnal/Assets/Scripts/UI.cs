using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public GameObject h1, h2, h3, l1, l2, l3, h1n, h2n, h3n, l1n, l2n, l3n;
    public static GameObject[] UIpos = new GameObject[6];
    public static GameObject[] UIneg = new GameObject[6];
    public static bool go = false;

    // Start is called before the first frame update
    void Start()
    {
        UIpos[0] = h1;
        UIpos[1] = h2;
        UIpos[2] = h3;
        UIpos[3] = l1;
        UIpos[4] = l2;
        UIpos[5] = l3;
        UIneg[0] = h1n;
        UIneg[1] = h2n;
        UIneg[2] = h3n;
        UIneg[3] = l1n;
        UIneg[4] = l2n;
        UIneg[5] = l3n;
    }

}
