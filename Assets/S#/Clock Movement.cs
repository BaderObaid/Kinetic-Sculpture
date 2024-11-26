using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClockMovement : MonoBehaviour
{
public float rotatespeed;
public GameObject minHand;
public GameObject hourHand;

    void Start()
    {
        rotatespeed = Time.deltaTime / 60;
    }

    // Update is called once per frame
    void Update()
    {
        minHand.transform.Rotate ( 0, 0 , -rotatespeed, Space.World);
        hourHand.transform.Rotate ( 0, 0 , -rotatespeed / 12, Space.World);
    }
}
