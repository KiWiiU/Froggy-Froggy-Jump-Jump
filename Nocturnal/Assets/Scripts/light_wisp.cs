using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class light_wisp : MonoBehaviour
{
    public GameObject self, thelight;

    void Start()
    {
        self.SetActive(true);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.name == "PlayerCapsule")
        {
            self.SetActive(false);
            Light light = thelight.GetComponent<Light>();
            if (light.intensity < 31)
            {
               light.intensity = light.intensity + 10;
               if (!UI.UIpos[3].activeSelf)
                {
                    UI.UIpos[3].SetActive(true);
                    UI.UIneg[3].SetActive(false);
                } else if (!UI.UIpos[4].activeSelf)
                {
                    UI.UIpos[4].SetActive(true);
                    UI.UIneg[4].SetActive(false);
                } else
                {
                    UI.UIpos[5].SetActive(true);
                    UI.UIneg[5].SetActive(false);
                }
            }
        }
    }
}
