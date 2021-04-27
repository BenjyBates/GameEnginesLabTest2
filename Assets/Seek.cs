using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;

public class Seek : SteeringBehaviour
{

    private GameObject _ball;

    public Vector3 target = Vector3.zero;

    public override Vector3 Calculate()
    {
        return boid.SeekForce(target);
    }

    private void Start()
    {

    }

    public void Update()
    {
        if (BallManager.ballThrown == true)
        {
            _ball = GameObject.FindGameObjectWithTag("Ball");
            target = _ball.transform.position;
        }
    }
}