using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public Rigidbody rb;

    public float forwardforce = 100f;
    public float lateralforce = 60f;

    private Transform trans;

    public float force_accumulator = 2.3f;//Math.E;
    // Start is called before the first frame update
    void Start()
    {
        rb.useGravity = true;
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(0,0,forwardforce*Time.deltaTime);

        if( Input.GetKey("a"))
        {
            //RIGHT
            rb.AddForce(-lateralforce*Time.deltaTime,0,0);
        }
        else if( Input.GetKey("d"))
        {
            //LEFT
            rb.AddForce(lateralforce*Time.deltaTime,0,0);
        }
        else if( Input.GetKey("w"))
        {
            //FORWARD
            rb.AddForce(0,0,forwardforce*Time.deltaTime);
        }
        else if( Input.GetKey("s"))
        {
            //BACK
            rb.AddForce(0,0,-forwardforce*Time.deltaTime);
        }
        else if( Input.GetKey("space"))
        {
            //BREAK
            //rb.AddForce(lateralforce*Time.deltaTime,0,forwardforce*Time.deltaTime);
        }
        else if( Input.GetKey("e"))
        {
            //COUNTER CLOCKWISE - LEFT TURN
            transform.RotateAround(transform.position, Vector3.up, 30*Time.deltaTime);
        }
        else if( Input.GetKey("q"))
        {
            transform.RotateAround(transform.position, Vector3.up, -30*Time.deltaTime);
        }
    }
}














