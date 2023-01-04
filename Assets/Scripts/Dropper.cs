using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dropper : MonoBehaviour
{
    [SerializeField] float timeToWait = 5f;

    Rigidbody rigidBody;
    MeshRenderer meshRenderer;

    void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        rigidBody = GetComponent<Rigidbody>();

        meshRenderer.enabled = false;
        rigidBody.useGravity = false;
    }

    void Update()
    {
        if(Time.time > timeToWait)
        {
            meshRenderer.enabled = true;
            rigidBody.useGravity = true;
        }
    }

    // void OnCollisionEnter(Collision other) 
    // {
    //     if(other.gameObject.tag == "Ground")
    //     {
    //         rigidBody.constraints = RigidbodyConstraints.FreezeAll;
    //     }    
    // }
}
