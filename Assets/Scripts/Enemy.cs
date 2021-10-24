using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float life = 1.0f, speed = 10.0f;
    public int value = 5;
    private Vector3 dir;
    public Player player;
    public HUD hud;
    const float LIMIT = 14.0f;
    public AudioSource hit;


    void FixedUpdate()
    {
       
       
    }

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Bullet" || other.gameObject.tag == "Player" || other.gameObject.tag == "Shield"){
            hit.Play();
            life = life - 1;
            if(life <= 0){
                Destroy(gameObject);
                hud.points = hud.points + value;
                player.energy += 0.1f;
            }
        }
    }
}
