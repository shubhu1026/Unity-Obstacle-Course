using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] float moveSpeed = 10f;

    float xValue = 0;
    float yValue = 0;
    float zValue = 0;

    void Update()
    {
        MovePlayer();
    }

    void MovePlayer()
    {
        xValue = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        zValue = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Translate(xValue, yValue, zValue);
    }
}
