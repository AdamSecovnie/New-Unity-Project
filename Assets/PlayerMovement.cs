using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float lateralspeed = 10f;

    public float vertical_speed;// = 2f * lateralspeed;
    void Start()
    {
        rb.useGravity = true;        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        vertical_speed = 2f * lateralspeed;
        //rb.AddForce(0,0,forwardforce*Time.deltaTime);

        if( Input.GetKey("d"))
        {
            //MOVE LEFT
            Debug.Log("right"+transform.right);
            rb.AddForce(transform.right*lateralspeed);
            //transform.SetPositionAndRotation(transform.TransformPoint(transform.localPosition+(Vector3.right*lateralspeed)), transform.rotation);
            //rb.AddForce(-lateralforce*Time.deltaTime,0,0);
        }
        if( Input.GetKey("a"))
        {
            //MOVE RIGHT
            Debug.Log("left"+-transform.right);
            rb.AddForce((-transform.right)*lateralspeed);
            //rb.AddForce(lateralforce*Time.deltaTime,0,0);
        }
        if( Input.GetKey("w"))
        {
            //FORWARD
            rb.AddForce(transform.forward*lateralspeed);
        }
        if( Input.GetKey("s"))
        {
            //BACK
            rb.AddForce((-transform.forward)*lateralspeed);
        }
        if( Input.GetKey("space"))
        {
            //JUMP
            rb.AddForce(Vector3.up*vertical_speed);
        }
        if( Input.GetKey("q"))
        {
            //COUNTER CLOCKWISE - LEFT TURN
            transform.RotateAround(transform.position, Vector3.up, 60*Time.deltaTime);
        }
        if( Input.GetKey("e"))
        {
            //COUNTER CLOCKWISE - RIGHT TURN
            transform.RotateAround(transform.position, Vector3.up, -60*Time.deltaTime);
        }
    }
}














