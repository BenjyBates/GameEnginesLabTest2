using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallManager : MonoBehaviour
{

    public static bool ballThrown;
    public static bool DoghasBall;

    public void Awake()
    {
        ballThrown = false;
        DoghasBall = false;
    }

}
