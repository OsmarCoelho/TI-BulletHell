using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public float life = 1.0f, speed = 10.0f;

    public int value = 5;

    private Vector3 dir;

    public Player player;

    public GameObject camera;

    public HUD hud;

    private float LIMIT = 14.0f;

    public AudioSource hit;

    void FixedUpdate()
    {
        LIMIT = camera.transform.position.z - 10;
        dir = new Vector3(0, 0, -1);
        transform.position = transform.position + dir * speed * Time.fixedDeltaTime;
        if(LIMIT > transform.position.z) {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet" || other.gameObject.tag == "Player" || other.gameObject.tag == "Shield")
        {
            hit.Play();
            life = life - 1;
            if (life <= 0)
            {
                Destroy(gameObject);
                hud.points = hud.points + value;
                player.energy += 0.1f;
            }
        }

        if (other.gameObject.tag == "Missile"){
            Destroy(gameObject);
            hud.points = hud.points + value;
            player.energy += 0.1f;
        }
    }
}
