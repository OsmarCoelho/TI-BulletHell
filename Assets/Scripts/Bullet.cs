using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 20.0f;
    private Vector3 dir = new Vector3(0, 0, 1);
    
    void Start()
    {
        Destroy(gameObject, 3.0f);
    }

    void Update()
    {
        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag != "Player" ||other.gameObject.tag != "Shield"){
            Destroy(gameObject);
        }
    }
}
