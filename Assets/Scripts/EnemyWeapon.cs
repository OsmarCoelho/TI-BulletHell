using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyWeapon : MonoBehaviour
{
    public GameObject bullet;

    public AudioSource shoot;

    void Start()
    {
        InvokeRepeating("spawn", 0, 2);
    }

    void spawn()
    {
        shoot.Play();
        Instantiate(bullet, transform.position, transform.rotation);
    }
}
