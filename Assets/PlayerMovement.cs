using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private Rigidbody rb;

    private Transform transformOfDown;

    public float speedModifier = 40f;
    public float verticalSpeedModifier = 500f;
    void Start()
    {
        this.rb = this.gameObject.GetComponent<Rigidbody>();
        rb.useGravity = false;
        
        // this.transformOfDown = this.GetComponentInParent<PlanetGrav>().planet.GetComponentInParent<Transform>();
        
        // if(!transformOfDown)
        // {
        //     Debug.LogError("missing transform of down in player movement");
        // }
        // else
        // {
        //     Debug.Log("Using ["+transformOfDown.gameObject.name+"] for ["+this.gameObject.name+"] in Player Movement");
        // }
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        //Vector3 localDown = transform.InverseTransformDirection(transformOfDown.position);
        //Debug.Log("Local Down at "+localDown);
    
        if( Input.GetKey("d"))
        {
            moveLeft();
        }
        if( Input.GetKey("a"))
        {
            moveRight();
        }
        if( Input.GetKey("w"))
        {
            moveForward();
        }
        if( Input.GetKey("s"))
        {
            moveBack();
        }
        if( Input.GetKeyDown("space"))
        {
            moveUp();
        }
        if( Input.GetKey("q"))
        {
            leftTurn();
        }
        if( Input.GetKey("e"))
        {
            rightTurn();
        }
        if( Input.GetKey("f"))
        {
            tiltUpBack();
        }
        if( Input.GetKey("r"))
        {
            tiltDownForward();
        }

        headsUp();
        // Keep player head up

    }

    void headsUp()
    {
        if(transform.rotation.x > 1 || transform.rotation.x < -1)
        {
            //force x toward 0
            //transform.SetPositionAndRotation(Vector3.Vector3());
        }
        if(transform.rotation.z > 1 || transform.rotation.z < -1)
        {
            //force z toward 0
            //transform.SetPositionAndRotation(Vector3.Vector3());
        }
    }
    void tiltDownForward()
    {
        transform.RotateAround(transform.position, -transform.right, -60*Time.deltaTime);
    }
    void tiltUpBack()
    {
        transform.RotateAround(transform.position, transform.right, -60*Time.deltaTime);
    }
    void rightTurn()
    {
        transform.RotateAround(transform.position, transform.up, -60*Time.deltaTime);
    }
    void leftTurn()
    {
        transform.RotateAround(transform.position, transform.up, 60*Time.deltaTime);
    }
    void moveForward()
    {
        rb.AddForce(transform.forward*speedModifier);
    }
    void moveBack()
    {
        rb.AddForce((-transform.forward)*speedModifier);
    }

    void moveRight()
    {
        //Debug.Log("left"+-transform.right);
        rb.AddForce((-transform.right)*speedModifier);
    }
    void moveLeft()
    {
        //Debug.Log("right"+transform.right);
        rb.AddForce(transform.right*speedModifier);
    
    }
    void moveUp()
    {
        rb.AddForce(-transform.up*speedModifier*verticalSpeedModifier);
    }
}














