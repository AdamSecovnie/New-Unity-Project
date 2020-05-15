using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightPosition : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
       transform.SetPositionAndRotation(transform.parent.position, transform.parent.transform.rotation);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
