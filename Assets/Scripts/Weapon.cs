using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public GameObject bullet;
    public AudioSource shoot;
    
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.Space)){
           shoot.Play();
           Instantiate(bullet, transform.position, transform.rotation);
       }
    }
}
