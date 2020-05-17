using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.125f;

    private void Start() 
    {
        //Vector3 follow_point = transform.parent.transform.TransformPoint(transform.localPosition);
        //transform.Translate( transform.position - transform.position, Space.World ) ;
    }

    void FixedUpdate()
    {
        //translate our offset from our position, relative to parent, and save as world position
        Vector3 follow_point = transform.parent.transform.TransformPoint(transform.localPosition);
        
        transform.SetPositionAndRotation(follow_point, player.transform.rotation)
;    }
}
