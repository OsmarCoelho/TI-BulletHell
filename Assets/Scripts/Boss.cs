using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public float life = 1.0f;

    public GameObject exit, bullet;

    public AudioSource hit, shoot;

    public string state = "IDLE";

    public Image LifeImg;

    public Player player;

    private int random;

    void Update()
    {
        random = Random.Range(0, 3);

        if (random == 0 && state == "IDLE")
        {
            Instantiate(bullet,
            exit.transform.position,
            exit.transform.rotation);

            Instantiate(bullet,
            new Vector3(exit.transform.position.x - 2,
                exit.transform.position.y,
                exit.transform.position.z),
            exit.transform.rotation);

            Instantiate(bullet,
            new Vector3(exit.transform.position.x + 2,
                exit.transform.position.y,
                exit.transform.position.z),
            exit.transform.rotation);
            state = "ATTACKING";

            shoot.Play();
            StartCoroutine(changeState(1.0f));
        }
        else if (random == 1 && state == "IDLE")
        {
            for (int i = -5; i < 5; i++)
            {
                shoot.Play();
                Instantiate(bullet,
                new Vector3(exit.transform.position.x + i,
                    exit.transform.position.y,
                    exit.transform.position.z + 1),
                exit.transform.rotation);
            }
            state = "ATTACKING";
            StartCoroutine(changeState(3.0f));
        }
        else if (random == 2 && state == "IDLE")
        {
            for (int i = 0; i < 10; i++)
            {
                shoot.Play();
                Vector3 pos = transform.position;
                Instantiate(bullet,
                new Vector3(Mathf.Cos(exit.transform.position.x),
                    exit.transform.position.y,
                    exit.transform.position.z),
                exit.transform.rotation);
            }
            state = "ATTACKING";
            StartCoroutine(changeState(1.0f));
        }

        UpdateLife();
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Bullet")
        {
            hit.Play();
            life = life - 0.01f;
            player.energy = player.energy + 0.1f;
        }
        if (other.gameObject.tag == "Missile")
        {
            hit.Play();
            life = life - 0.1f;
            player.energy = player.energy + 0.1f;
        }

        if (life <= 0.0f)
        {
            SceneManager.LoadScene("Creditos");
        }
    }

    public void UpdateLife()
    {
        LifeImg.fillAmount = life;
    }

    IEnumerator changeState(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        state = "IDLE";
    }
}
