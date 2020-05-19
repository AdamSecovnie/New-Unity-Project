using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    
    private Transform player;
    public Vector3 offset = new Vector3(0f,0.5f,-1f);
    
    public float smoothSpeed = 0.125f;
    
    
    
    private Quaternion rotationOffset;
    private Vector3 follow_point;

    private void Start() 
    {
        this.player = transform.parent.GetComponentInParent<Transform>();//get our parent's tranform
        Debug.Log("[ "+this.name + " ]  got transform for [ "+player.name+ " ] in FollowPlayer");
        
        rotationOffset.Set(player.rotation.x, player.rotation.y, player.rotation.z, 1);
    }

    void FixedUpdate()
    {
        
        //  Debug.Log("Player Local ["+player.localPosition+"]\nPlayer Global ["+player.position+"]\n Follower Local ["+transform.localPosition+"]\n Follower Global["+transform.position+"]");

        //get the point of the offset relative to the player in global space
        follow_point = player.TransformPoint(offset);
        
        transform.SetPositionAndRotation(follow_point, player.rotation);
        
;    }
}
