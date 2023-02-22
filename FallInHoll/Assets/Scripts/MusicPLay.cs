using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MusicPLay : MonoBehaviour
{
    public GameObject lvlsound;
    private GameObject lvlsoundGO;

    // Use this for initialization
    void Start()
    {
        var lvl_sound = GameObject.Find("Music");
        if (lvl_sound == null)
        {
            lvlsoundGO = Instantiate(lvlsound);
            lvlsoundGO.name = "Music";
        }
        DontDestroyOnLoad(GameObject.Find("Music"));

        if (PlayerPrefs.GetInt("music") == 1)
        {
            GameObject.Find("Music").GetComponent<AudioSource>().enabled = true;
        }
        else
        {
            GameObject.Find("Music").GetComponent<AudioSource>().enabled = false;
        }
    }

    public void OnMusic()
    {
        GameObject.Find("Music").GetComponent<AudioSource>().enabled = true;
    }
    public void OffMusic()
    {
        GameObject.Find("Music").GetComponent<AudioSource>().enabled = false;
    }
}
