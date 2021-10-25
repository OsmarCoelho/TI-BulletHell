using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BigEnemy : MonoBehaviour
{
    public float life = 5.0f;

    public int value = 15;

    public Player player;

    public HUD hud;
    public AudioSource hit;

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
    }
}
