using System.Collections;
using UnityEngine;

public class Shield : MonoBehaviour
{
    public GameObject shield;
    public AudioSource hit;
    private bool isActive = false;
    
    public void toggleShieldState(){
        if(!isActive){
            shield.SetActive(true);  
            isActive = true;
        }  
        StartCoroutine(WaitTimeOut(3));
    }

    private void OnCollisionEnter(Collision other){
        if(other.gameObject.tag == "Enemy" || other.gameObject.tag == "EnemyBullet"){
            hit.Play();
        }
    }

    IEnumerator WaitTimeOut(float seconds){
        yield return new WaitForSeconds(seconds);
        isActive = false;
        shield.SetActive(false);
    }
}
