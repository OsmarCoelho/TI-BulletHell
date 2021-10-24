using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyBullet : MonoBehaviour
{
    public float speed = 20.0f;
    private Vector3 dir = new Vector3(0, 0, -1);
    
    void Update()
    {
        transform.position = transform.position + dir * speed * Time.deltaTime;
        if(transform.position.z <= -20){
            Destroy(gameObject);
        }
    }

    void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Player"){
            Destroy(gameObject);
        }
    }
}
