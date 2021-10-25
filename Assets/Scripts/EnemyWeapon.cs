using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public GameObject bullet;

    public AudioSource shoot;
    public float interval = 2.0f;

    void Start()
    {
        InvokeRepeating("spawn", 0, interval);
    }

    void spawn()
    {
        shoot.Play();
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
