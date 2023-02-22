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
        DontDestroyOnLoad(lvlsoundGO);
    }

    public void OnMusic()
    {
        lvlsoundGO.GetComponent<AudioSource>().enabled = true;
    }
    public void OffMusic()
    {
        lvlsoundGO.GetComponent<AudioSource>().enabled = false;
    }
}
