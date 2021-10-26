using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{    
    public string actualScene, nextScene;
    public bool isPaused = false;
    public GameObject pauseScreen;
    public Player player;

    public void changeScene(string scene)
    {
        SceneManager.LoadScene (scene);
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R)){
            changeScene(actualScene);
        }else if(Input.GetKeyDown(KeyCode.F2)){
            changeScene(nextScene);
        }else if(Input.GetKeyDown(KeyCode.F3)){
            player.lifeCheat = true;
        }else if(Input.GetKeyDown(KeyCode.Escape)){
            togglePause();
        }
    }

    public void togglePause(){
        isPaused = !isPaused;
        //Time.timeScale = isPaused ? 1 : 0;
        pauseScreen.SetActive(isPaused);
    }


}
