using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class NewS2 : MonoBehaviour
{
   
//    Rigidbody rgdbody;
   
//        public float moveSpeed;
//        public float leftAngel;
//        public float rightAngel;

//        bool movingClockwise;

        float MaxAngleDeflection = 30.0f;
        float SpeedOfPendulum = 1.0f;
        public Transform myPivotTransform;

        void Start()
        {

            //rgdbody = GetComponent<Rigidbody>();

        
        }

        void Update()
        {
           float angle = MaxAngleDeflection * Mathf.Sin( Time.time * SpeedOfPendulum);
           myPivotTransform.localRotation = Quaternion.Euler (new Vector3 ( 0, 0, angle)); 
            Debug.Log (transform.rotation.z);
            //transform.rotation = Quaternion.Euler(new Vector3(transform.position.x, transform.position.y, angle ));
           // rgdbody.angularVelocity = new Vector3(0, 0, moveSpeed); 
        } 
        
}
