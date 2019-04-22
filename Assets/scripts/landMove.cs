using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class landMove : MonoBehaviour
{
    public GameObject player;
    private Transform pc;
    public float distance;
    private bool landReady;

    void Update()
    {
        pc = player.transform;

        if(pc.position.x - transform.position.x >= distance)
        {
            landReady = false;
        }

        if(pc.position.x - transform.position.x > distance&&!landReady)
        {
            this.transform.position = new Vector2(transform.position.x + 18, transform.position.y);
            //draw land scape
            GetComponent<waterShapes>().DrawTheland();
            landReady = true;
        }

    }
}
