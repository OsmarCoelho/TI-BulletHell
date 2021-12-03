using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeAfter : MonoBehaviour
{
    public string scene;

    void Start(){
        Invoke("changeSceneAfter", 3);
    }
    
    void changeSceneAfter()
    {
        SceneManager.LoadScene(scene);
    }
}
