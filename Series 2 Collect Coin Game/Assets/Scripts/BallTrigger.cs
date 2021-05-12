using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallTrigger : MonoBehaviour
{ 
        public GameObject objectToToggle;

    private void OnTriggerEnter(Collider other)
    {
            if (other.gameObject.tag == "Ball")
        {
             if (objectToToggle.active == true)
         {
            objectToToggle.SetActive(false);
      
         }
     }
    }


}
