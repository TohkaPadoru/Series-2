using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocktimer : MonoBehaviour
{
    bool blockOn = true;
    public float timerblockOnLength = 2;
    public float timerblockOffLength = 3;
    float timeLeftOn;
    float timeLeftOff;

    public MeshCollider collider;
    public MeshRenderer renderer;


    void Start()
    {
        timeLeftOn = timerblockOnLength;
        timeLeftOff = timerblockOffLength;
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")

        {
            Debug.Log("collision");
            Invoke("DisableBlock", 2.0f);

        }
        

    }
    void DisableBlock()
    {
        collider.enabled=false;
        renderer.enabled=false;
        Invoke("EnableBlock", 2.5f);
    }

    void EnableBlock()
    {
        collider.enabled=true;
        renderer.enabled=true;
    }
}
