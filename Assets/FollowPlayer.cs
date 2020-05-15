using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    public Transform player;
    public Vector3 offset;
    public float smoothSpeed = 0.25f;

    void FixedUpdate()
    {
        //translate our offset from our position, relative to parent, and save as world position
        Vector3 follow_point = transform.parent.transform.TransformPoint(transform.localPosition);

        Debug.Log("follow point:["+follow_point+"] ; player local ["+player.localPosition+"]");
        
        transform.SetPositionAndRotation(follow_point, player.transform.rotation)
;    }
}
