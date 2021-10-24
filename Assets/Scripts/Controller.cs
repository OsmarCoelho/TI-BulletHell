using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Controller : MonoBehaviour
{
    // Start is called before the first frame update
    public string actualScene, nextScene;
    public Player player;

    public void changeScene(string scene)
    {
        SceneManager.LoadScene (scene);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R))
        {
            changeScene(actualScene);
        }else if(Input.GetKeyDown(KeyCode.F2)){
            changeScene(nextScene);
        }else if(Input.GetKeyDown(KeyCode.F3)){
            player.lifeCheat = true;
        }
    }
}
