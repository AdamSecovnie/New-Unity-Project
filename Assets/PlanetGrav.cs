using UnityEngine;
using System.Collections;
using System.IO;

public class PlanetGrav : MonoBehaviour 
{   
    public GameObject planet;
    Rigidbody planetRigidbody;
    void FixedUpdate () {


        float magsqr;
        Vector3 offset;
        offset = planet.transform.position - transform.position;

        magsqr = offset.sqrMagnitude;
        planetRigidbody = planet.GetComponentInChildren<Rigidbody>();

        Rigidbody rb = this.gameObject.GetComponentInParent<Rigidbody>();
        if(!rb){ Debug.LogError("PlantGrav.cs in ["+this.gameObject.name+"] missing parent's Rigidbody"); }

        //Check distance is more than 0 to prevent division by 0
        if (magsqr > 0.0001f && planet)
        {
            //Create the gravity- make it realistic through division by the "magsqr" variable
            rb.AddForce((planetRigidbody.mass *.05f* offset.normalized / magsqr) * rb.mass);
        }
        else
        {
            Debug.LogError("["+this.gameObject.name+"] failed to add force to ["+rb.GetComponentInParent<GameObject>().name+"] likely due to missing planet in PlanetGrav.cs");
        }
    }
}
