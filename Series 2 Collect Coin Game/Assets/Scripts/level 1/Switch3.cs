using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch3 : MonoBehaviour
{ 
    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.tag == "Player")
        {
            GameObject.Find("Barricade 3")
                .SendMessage("Sleep");
        }

    }
}