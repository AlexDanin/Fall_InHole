using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundPLay : MonoBehaviour
{
    bool flag = true;
    private void Start()
    {
        flag = true;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "count" && flag && PlayerPrefs.GetInt("sound") == 1)
        {
            gameObject.GetComponent<AudioSource>().Play();
            flag = false;
        }
    }
}
