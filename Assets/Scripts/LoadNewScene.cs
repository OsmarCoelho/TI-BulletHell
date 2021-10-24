using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadNewScene : MonoBehaviour
{
    
    public string scene;
    
    public void changeScene(){
        SceneManager.LoadScene(scene);
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag != "Bullet" && other.gameObject.tag != "Enemy" && other.gameObject.tag != "EnemyBullet")
            changeScene();
    }
}
