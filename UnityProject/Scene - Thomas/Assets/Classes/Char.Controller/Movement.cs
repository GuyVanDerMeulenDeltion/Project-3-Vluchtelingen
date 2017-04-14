using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Vector3 camRotatie;
    public Vector3 rotatieS;
    public GameObject cam;
    public float speed;
    public float adjustmentsspeed;
    public float minaxis;
    public float maxaxis;
    public Vector3 links;
    public float hor;
    public float ver;
    public float accel;

    void Start()
    {

    }


    void FixedUpdate()
    {
       
        hor = Input.GetAxis("Horizontal");
        ver = Input.GetAxis("Vertical");

      
        links.x = hor;
        links.z = ver;

       
        transform.Translate(links * Time.deltaTime * accel);


    }

    void Update()
    {
        
        if (Input.GetButtonDown("o"))
        {
            decreasesen();
        }

     
        if (Input.GetButtonDown("p"))
        {
            increasesen();
        }

      
        if (speed < 1)
        {
            speed = 1;
        }

       
        if (speed < minaxis)
        {
            speed = minaxis;
        }

     
        if (speed > maxaxis)
        {
            speed = maxaxis;
        }

  
        rotatieS = rotatieS * Time.deltaTime;
        camRotatie = camRotatie * Time.deltaTime;

      
        rotatieS.y = Input.GetAxis("Mouse X") * speed;
        camRotatie.x = Input.GetAxis("Mouse Y") * -speed;

        transform.Rotate(rotatieS);
        cam.transform.Rotate(camRotatie);



    }

    public void increasesen()
    {
        speed = speed + adjustmentsspeed;
    }

    public void decreasesen()
    {
        speed = speed - adjustmentsspeed;
    }
}
