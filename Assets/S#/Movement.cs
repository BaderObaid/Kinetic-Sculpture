using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{

    public float speed = 1f;
    private float counter = 0;
    private float x = 0;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       // counter += 0.0025f;
       // x += counter;
        float xNew = Mathf.Sin(Time.time);
        // transform.position += new Vector3 (xNew , transform.position.y, transform.position.z);
        transform.rotation = Quaternion.Euler(new Vector3 (xNew * Time.deltaTime * 45f , 0, 0));
    }

}
