using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour
{
    [SerializeField] float speedRotation = 300f;
    bool draging = false;
    Rigidbody rb;
    Transform tr;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        draging = Input.GetMouseButton(0);


        if(!Controller.track)
        {
            tr.transform.localPosition = new Vector3(0,0,0);
            tr.transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
    }


    void FixedUpdate()
	{

        if (draging)
        {
            float x = Input.GetAxis("Mouse X") * speedRotation * Time.fixedDeltaTime;
            float y = Input.GetAxis("Mouse Y") * speedRotation * Time.fixedDeltaTime;

            rb.AddTorque(Vector3.up * x);
            rb.AddTorque(Vector3.right * y);
        }
        
    }    
}
