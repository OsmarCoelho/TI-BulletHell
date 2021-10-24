using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableAll : MonoBehaviour
{
    public GameObject[] objs;

    void EnableAllObjs()
    {
        foreach (GameObject obj in objs)
        {
            obj.SetActive(true);
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag != "Bullet")
        {
            EnableAllObjs();
            Destroy (gameObject);
        }
    }
}
