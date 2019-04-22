using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerMove : MonoBehaviour
{
    

    void FixedUpdate()
    {
        if (Input.GetMouseButton(0))
        {
            this.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.right*20f);
        }
    }
}
