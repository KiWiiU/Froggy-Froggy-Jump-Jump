using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class constantHit : MonoBehaviour
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
            AudioSource audio = gameObject.AddComponent<AudioSource>();
            audio.PlayOneShot((AudioClip)Resources.Load("Models/fail"));
            Light light = thelight.GetComponent<Light>();
            if (light.intensity > 1)
            {
                light.intensity = light.intensity - 10;
                if (UI.UIpos[5].activeSelf)
                {
                    UI.UIpos[5].SetActive(false);
                    UI.UIneg[5].SetActive(true);
                }
                else if (UI.UIpos[4].activeSelf)
                {
                    UI.UIpos[4].SetActive(false);
                    UI.UIneg[4].SetActive(true);
                }
                else
                {
                    UI.UIpos[3].SetActive(false);
                    UI.UIneg[3].SetActive(true);
                }
            }
            else
            {
                if (UI.UIpos[2].activeSelf)
                {
                    UI.UIpos[2].SetActive(false);
                    UI.UIneg[2].SetActive(true);
                }
                else if (UI.UIpos[1].activeSelf)
                {
                    UI.UIpos[1].SetActive(false);
                    UI.UIneg[1].SetActive(true);
                }
                else if (UI.UIpos[0].activeSelf)
                {
                    UI.UIpos[0].SetActive(false);
                    UI.UIneg[0].SetActive(true);
                }
                else
                {
                    SceneManager.LoadScene("GameOver");
                }
            }
        }
    }
}
