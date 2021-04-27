using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dropball : MonoBehaviour
{
    public Collider player;

    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Ball" && BallManager.DoghasBall == true)
        {
            BallManager.DoghasBall = false;
            DogStates._state = DogStates.DogBrain.DROP;
        }
    }


}
