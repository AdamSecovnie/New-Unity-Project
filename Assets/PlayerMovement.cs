using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float lateralspeed;

    void Start()
    {
        rb.useGravity = true;        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0,0,forwardforce*Time.deltaTime);

        if( Input.GetKey("d"))
        {
            //MOVE LEFT
            Debug.Log("right"+transform.right);
            rb.AddForce(transform.right*lateralspeed);
            //transform.SetPositionAndRotation(transform.TransformPoint(transform.localPosition+(Vector3.right*lateralspeed)), transform.rotation);
            //rb.AddForce(-lateralforce*Time.deltaTime,0,0);
        }
        else if( Input.GetKey("a"))
        {
            //MOVE RIGHT
            Debug.Log("left"+-transform.right);
            rb.AddForce((-transform.right)*lateralspeed);
            //rb.AddForce(lateralforce*Time.deltaTime,0,0);
        }
        else if( Input.GetKey("w"))
        {
            //FORWARD
            rb.AddForce(transform.forward*lateralspeed);
        }
        else if( Input.GetKey("s"))
        {
            //BACK
            rb.AddForce((-transform.forward)*lateralspeed);
        }
        else if( Input.GetKey("space"))
        {
            //JUMP
            rb.AddForce(transform.up*lateralspeed*6);
        }
        else if( Input.GetKey("e"))
        {
            //COUNTER CLOCKWISE - LEFT TURN
            transform.RotateAround(transform.position, Vector3.up, 30*Time.deltaTime);
        }
        else if( Input.GetKey("q"))
        {
            //COUNTER CLOCKWISE - RIGHT TURN
            transform.RotateAround(transform.position, Vector3.up, -30*Time.deltaTime);
        }
    }
}














