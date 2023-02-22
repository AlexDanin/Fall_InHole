using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuManager : MonoBehaviour
{
    [SerializeField]
    private GameObject soundOn, soundOff, musicOn, musicOff, move1, move2;

    void Start()
    {
        if (!PlayerPrefs.HasKey("music"))
            PlayerPrefs.SetInt("music", 1);
        if (!PlayerPrefs.HasKey("sound"))
            PlayerPrefs.SetInt("sound", 1);
        if (!PlayerPrefs.HasKey("move"))
            PlayerPrefs.SetInt("move", 1);

        if (PlayerPrefs.GetInt("move") == 1)
        {
            move1.SetActive(true);
            move2.SetActive(false);
        }
        else
        {
            move1.SetActive(false);
            move2.SetActive(true);
        }
        if (PlayerPrefs.GetInt("music") == 1)
        {
            musicOn.SetActive(true);
            musicOff.SetActive(false);
        }
        else
        {
            musicOn.SetActive(false);
            musicOff.SetActive(true);
        }
        if (PlayerPrefs.GetInt("sound") == 1)
        {
            soundOn.SetActive(true);
            soundOff.SetActive(false);
        }
        else
        {
            Debug.Log("off");
            soundOn.SetActive(false);
            soundOff.SetActive(true);
        }
    }

    public void music_on()
    {
        PlayerPrefs.SetInt("music", 1);
    }
    public void music_off()
    {
        PlayerPrefs.SetInt("music", 0);
    }

    public void sound_on()
    {
        PlayerPrefs.SetInt("sound", 1);
    }
    public void sound_off()
    {
        PlayerPrefs.SetInt("sound", 0);
    }

    public void finger()
    {
        PlayerPrefs.SetInt("move", 1);
    }
    public void cursor()
    {
        PlayerPrefs.SetInt("move", 0);
    }
}
