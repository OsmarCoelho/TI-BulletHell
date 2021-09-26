using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private float speed = 10.0f, damage = 1.0f;
    void Start()
    {
        Destroy(gameObject, 3.0f);
    }

    
    void Update()
    {
        transform.Translate(transform.up * speed * Time.deltaTime);
    }
}
