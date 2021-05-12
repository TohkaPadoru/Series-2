using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class timedswitch : MonoBehaviour
{
    void OnTriggerExit(Collider hit)
    {
        if (hit.gameObject.tag == "Player")

        {  
            Invoke("Disable",0.2f);
        }

        void Disable()
        {
            GameObject.Find("Barricade 2")
                .SendMessage("React", 10.0f);

            Invoke("Enable", 2.0f);
        }

        void enable()
        {
            GameObject.Find("Barricade 2")
                .SendMessage("Harden");
        }
    }
}