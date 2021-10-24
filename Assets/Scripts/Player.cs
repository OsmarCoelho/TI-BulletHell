using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Player : MonoBehaviour
{
    const float LIMIT = 13.0f;
    private float h, v;
    private bool canShieldBeActive = true/* , canMissileBeLaunched = true */;
    private Vector3 dir;
    public float speed = 10.0f, life = 1.0f, energy = 0.0f;
    public bool lifeCheat = false;
    public GameObject weapon;
    public Shield shield;
    public AudioSource hit, dies;
    
    void Update()
    {
        h = Input.GetAxis("Horizontal");
        v = Input.GetAxis("Vertical");

        if(transform.position.x < -LIMIT){
            h = h + 1;
        }else if(transform.position.x > LIMIT){
            h = h - 1;
        }

        if(transform.position.z < -LIMIT){
            v = v + 1;
        }

        if(Input.GetKeyDown(KeyCode.L) && canShieldBeActive){
           shield.toggleShieldState();  
           canShieldBeActive = false;
           StartCoroutine(shieldCooldown(5));
       }else if (Input.GetKeyDown(KeyCode.L)){
           Debug.Log("Escudo não pode ser ativado");
       }

        transform.rotation = Quaternion.Euler(0, 0, -30 * h);
        dir = new Vector3(h, 0, v);

        transform.position = transform.position + dir * speed * Time.deltaTime;
    }

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "EnemyBullet" && !shield.gameObject.activeSelf && !lifeCheat){
            hit.Play();
            life = life - 0.1f;
        }else if(other.gameObject.tag == "Enemy" && !shield.gameObject.activeSelf && !lifeCheat){
            hit.Play();
            life = life - 0.1f;
        }else if(other.gameObject.tag == "Vida"){
            life = life + 0.5f;
            if(life > 1.0f){
                life = 1.0f;
            }
        }else if(other.gameObject.tag == "Weapon"){
            weapon.SetActive(true);
        };

        if(life <= 0){
            StartCoroutine(playerDies(1));
        }
    }

    IEnumerator shieldCooldown(float seconds){
        yield return new WaitForSeconds(seconds);
        canShieldBeActive = true;
    }

    IEnumerator playerDies(float seconds){
        dies.Play();
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("GameOver");
    }
}
