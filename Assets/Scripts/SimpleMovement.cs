using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Mirror;

public class SimpleMovement : MonoBehaviour
{
    void HandleMovement()
    {
        if (true)
        {
            float moveHorizontal = Input.GetAxis("Horizontal");
            float moveVertical = Input.GetAxis("Vertical");
            Vector3 movement = new Vector3(moveHorizontal * 0.1f, moveVertical * 0.1f, 0);
            transform.position = transform.position + movement;
        }
    }

    // Update is called once per frame
    void Update()
    {
        HandleMovement();
    }
}
