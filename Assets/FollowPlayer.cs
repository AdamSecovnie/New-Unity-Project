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
        Vector3 follow_point = player.transform.TransformPoint(transform.localPosition);
        Debug.Log("follow point:["+follow_point+"] ; player local ["+player.localPosition+"]");
        transform.SetPositionAndRotation(follow_point, player.transform.rotation)
;    }
}
