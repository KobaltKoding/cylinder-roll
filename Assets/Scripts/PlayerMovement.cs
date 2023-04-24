using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;




public class PlayerMovement : MonoBehaviour
{

    public Rigidbody rb;
    public Transform cylinder;
    

    static float forwardForce=1500f;
    public float rotateForce = 500f;
    //public float jumpForce = 120f;
    private float width;
    private float height;

    private void Awake()
    {
        width = (float)Screen.width / 2.0f;
        height = (float)Screen.height / 2.0f;
    }
    // Update is called once per frame
    void FixedUpdate()
    {
        rb.AddForce(0, 0, forwardForce * Time.deltaTime);

        if(Input.GetKey("d"))
        {
            //rb.AddForce(0, rotateForce * Time.deltaTime, 0, ForceMode.VelocityChange);
            cylinder.Rotate(0, 0, rotateForce * Time.deltaTime);
            
        }

       
        if (Input.GetKey("a"))
        {
            // rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
            cylinder.Rotate(0, 0, -rotateForce * Time.deltaTime);
        }


        if (Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);
            Vector2 pos = touch.position;
            pos.x = (pos.x - width) / width;
            pos.y = (pos.y - height) / height;

            if (pos.x>0)
            {
                //rb.AddForce(0, rotateForce * Time.deltaTime, 0, ForceMode.VelocityChange);
                cylinder.Rotate(0, 0, rotateForce * Time.deltaTime);

            }


            if (pos.x<0)
            {
                // rb.AddForce(-sidewaysForce * Time.deltaTime, 0, 0, ForceMode.VelocityChange);
                cylinder.Rotate(0, 0, -rotateForce * Time.deltaTime);
            }
        }


    }

    public void Difficulty(float speed)
    {
        forwardForce = speed;
    }

    public void Stop()
    {
        rb.velocity = new Vector3(0, 0, 0);
    }
}
