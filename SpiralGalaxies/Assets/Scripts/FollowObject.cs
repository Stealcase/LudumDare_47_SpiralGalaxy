using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowObject : MonoBehaviour
{

    public Transform target;
    // Start is called before the first frame update

    // Update is called once per frame
    void FixedUpdate()
    {
        transform.position = target.position;
    }
}
