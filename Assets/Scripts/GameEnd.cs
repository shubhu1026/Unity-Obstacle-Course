using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameEnd : MonoBehaviour
{
    void OnTriggerEnter(Collider other) 
    {
        SceneManager.LoadScene(0);
    }
}
