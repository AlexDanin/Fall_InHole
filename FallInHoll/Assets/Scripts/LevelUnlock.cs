using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelUnlock : MonoBehaviour
{
    [SerializeField]
    private GameObject[] levels;
    int lvl_number;
    void Start()
    {
        lvl_number = PlayerPrefs.GetInt("lvl_record") - 1;

        for (int i = 0; i < lvl_number; i++)
        {
            levels[i].transform.Find("lock").gameObject.SetActive(false);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
