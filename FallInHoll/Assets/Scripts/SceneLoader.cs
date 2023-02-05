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
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene("Main");
    }
}
