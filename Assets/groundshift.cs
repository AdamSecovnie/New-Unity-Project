using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundshift : MonoBehaviour
{
    public Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        ///rb.useGravity = true;
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //rb.AddForce(Vector3.up*0.0001f);
    }
}
