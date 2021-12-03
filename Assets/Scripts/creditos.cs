using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class creditos : MonoBehaviour
{
    void Update()
    {
        transform.position = transform.position + new Vector3(0, 1, 0) * 100 * Time.deltaTime;
        StartCoroutine(wait(10.0f));
    }

    IEnumerator wait(float seconds)
    {
        yield return new WaitForSeconds(seconds);
        SceneManager.LoadScene("Win");
    }
}
