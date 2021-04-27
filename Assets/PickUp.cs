using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public Collider col;
    public GameObject DogMouth;
    public GameObject _ball;

    public void Update()
    {
         if(BallManager.ballThrown == true)
         {
            _ball = GameObject.FindGameObjectWithTag("Ball");
         }

         if(BallManager.DoghasBall == true)
        {
            _ball.transform.position = DogMouth.transform.position;
        }
    }

    public void OnTriggerEnter(Collider other)
    {     
            if (other.gameObject.tag == "Ball" && BallManager.DoghasBall == false)
            {
                BallManager.DoghasBall = true;
                DogStates._state = DogStates.DogBrain.FETCH;
            }
    }
}
