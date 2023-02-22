using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoader : MonoBehaviour
{
    private void Start()
    {
        if (!PlayerPrefs.HasKey("lvl"))
            PlayerPrefs.SetInt("lvl", 1);
        if (!PlayerPrefs.HasKey("lvl_record"))
            PlayerPrefs.SetInt("lvl_record", 1);
    }
    public void LevelSelect(int level)
    {
        PlayerPrefs.SetInt("lvl", level);
        LoadLevel();
    }

    public void LoadLevel()
    {
        if (PlayerPrefs.GetInt("lvl") <= 10)
            SceneManager.LoadScene("Levels");
        if (10 < PlayerPrefs.GetInt("lvl") && PlayerPrefs.GetInt("lvl") <= 20)
            SceneManager.LoadScene("Levels3");
        if (20 < PlayerPrefs.GetInt("lvl") && PlayerPrefs.GetInt("lvl") <= 30)
            SceneManager.LoadScene("Levels2");
        Time.timeScale = 1;

    }
    public void LoadMenu()
    {
        Time.timeScale = 1;
        SceneManager.LoadScene("Main");
    }


    public void Pause()
    {
        Time.timeScale = 0;
    }

    public void Resume()
    {
        Time.timeScale = 1;
    }
}
