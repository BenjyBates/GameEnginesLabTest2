using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Throw : MonoBehaviour
{
    public GameObject ball;
    public float speed = 20;
    public Transform MainCam;

    public float ballNo = 1f;
    private float nextTimeToThrow = 0f;

    // Start is called before the first frame update
    void Update()
    {
        if (Input.GetButton("Fire2") && Time.time >= nextTimeToThrow)
        {
            nextTimeToThrow = Time.time + 1 / ballNo;
            Shoot();
        }
    }
    public void Shoot()
    {
        GameObject _ball = Instantiate(ball, MainCam.position, MainCam.rotation) as GameObject;
        _ball.GetComponent<Rigidbody>().AddForce(MainCam.forward * speed, ForceMode.Impulse);
    }
}
