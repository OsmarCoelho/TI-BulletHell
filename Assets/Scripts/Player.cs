using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    const float LIMIT = 6.0f;
    private float h, v, speed = 12.0f, vida = 100.0f, energia = 100.0f;
    private Vector3 dir;
    void Start()
    {
        
    }

    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if(transform.position.x < -LIMIT){
            h = h + 1;
        }else if(transform.position.x > LIMIT){
            h = h - 1;
        }

        transform.rotation = Quaternion.Euler(0, -30 * h, 0);
        dir = new Vector3(h, v, 0);

        transform.position = transform.position + dir * speed * Time.deltaTime;
    }
}
