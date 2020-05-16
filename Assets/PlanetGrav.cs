using UnityEngine;
using System.Collections;

public class PlanetGrav : MonoBehaviour 
{
    public Rigidbody rb;
    public float StrengthOfAttraction;
    public GameObject planet;

    void FixedUpdate () {

        float magsqr;
        Vector3 offset;
        offset = planet.transform.position - transform.position;

        magsqr = offset.sqrMagnitude;

        //Check distance is more than 0 to prevent division by 0
        if (magsqr > 0.0001f)
        {
            //Create the gravity- make it realistic through division by the "magsqr" variable
            rb.AddForce((StrengthOfAttraction * offset.normalized / magsqr) * rb.mass);
        }
    }
}
