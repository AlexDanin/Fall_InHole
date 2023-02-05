using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelManager : MonoBehaviour
{
    [SerializeField]
    private GameObject[] lvl;
    int level = 0;
    void Start()
    {
        level = PlayerPrefs.GetInt("lvl") - 1;
        Debug.Log(level);
        var obj = Instantiate(lvl[level]);
        // obj.name = "lvl";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
