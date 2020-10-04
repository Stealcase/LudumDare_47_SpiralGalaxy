using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollisionManager : MonoBehaviour
{
    public bool isGrounded = false;
    private float distanceToGround;

    public void Awake()
    {
        distanceToGround = this.GetComponentInChildren<SphereCollider>().bounds.extents.y;
    }
    public void GroundCheck()
    {
        isGrounded = Physics.Raycast(transform.position, -Vector3.up, distanceToGround + 0.1f);
    }
    public void Update()
    {
        GroundCheck();
    }

}
