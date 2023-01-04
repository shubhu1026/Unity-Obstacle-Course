using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ObjectHit : MonoBehaviour
{
    Material hitObjectsMaterial;
        
    void Awake()
    {
        hitObjectsMaterial = (Material)AssetDatabase.LoadAssetAtPath("Assets/Materials/Hit Objects Material.mat", typeof(Material));
    }


    void OnCollisionEnter(Collision other) 
    {
        if(other.gameObject.tag == "Player")
        {
            if(hitObjectsMaterial != null)
            GetComponent<MeshRenderer>().material = hitObjectsMaterial;
        }
    }
}
