using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scorer : MonoBehaviour
{
    int hits = 0;

    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag != "Ground" && other.gameObject.tag != "Hit")
        {
            hits++;
            other.gameObject.tag = "Hit";
            Debug.Log("You've hit other objects: " + hits + " times");
        }
    }
}
