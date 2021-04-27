using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DogStates : MonoBehaviour
{
    public enum DogBrain { WAIT,SEEK,FETCH,DROP}

    public GameObject Player;
    public GameObject Dog;
    public static DogBrain _state;

    void Update()
    {

        switch (_state)
        {
            case DogBrain.WAIT:
                Dog.GetComponent<Arrive>().enabled = false;
                Dog.GetComponent<Seek>().enabled = false;
                break;
            case DogBrain.SEEK:
                Dog.GetComponent<Seek>().enabled = true;
                break;
            case DogBrain.FETCH:
                Dog.GetComponent<Arrive>().enabled = true;
                Dog.GetComponent<Seek>().enabled = false;
                break;
            case DogBrain.DROP:
                Destroy(GameObject.FindGameObjectWithTag("Ball"));
                BallManager.ballThrown = false;
                _state = DogBrain.WAIT;
                break;

        }
        
    }
}
